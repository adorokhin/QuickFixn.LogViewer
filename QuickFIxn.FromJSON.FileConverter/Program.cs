using System;
using System.IO;
using System.Text.Json;
using QuickFix;
using QuickFix.DataDictionary;
using QuickFix.Fields;

namespace QuickFIxn.JSON.FileConverter
{
    public static class FixExt
    {

        public static DataDictionary ApplicationDataDictionary { get; private set; }

        public static int BodyLength(this Message msg)
        {
            return msg.Header.CalculateLength() + msg.CalculateLength() + msg.Trailer.CalculateLength();
        }

        public static void FromJson
            (this Message msg, string json, bool validate, DataDictionary sessionDD,
            DataDictionary appDD, IMessageFactory msgFactory)
        {
            ApplicationDataDictionary = appDD;
            msg.Clear();

            using (JsonDocument document = JsonDocument.Parse(json))
            {
                string beginString = document.RootElement.GetProperty("Header").GetProperty("BeginString").GetString();
                string msgType = document.RootElement.GetProperty("Header").GetProperty("MsgType").GetString();
                IFieldMapSpec msgMap = appDD.GetMapForMessage(msgType);
                FromJson(document.RootElement.GetProperty("Header"), beginString, msgType, msgMap, msgFactory, sessionDD, msg.Header);
                FromJson(document.RootElement.GetProperty("Body"), beginString, msgType, msgMap, msgFactory, appDD, msg);
                FromJson(document.RootElement.GetProperty("Trailer"), beginString, msgType, msgMap, msgFactory, sessionDD, msg.Trailer);
            }

            msg.Header.SetField(new BodyLength(msg.BodyLength()), true);
            msg.Trailer.SetField(new CheckSum(QuickFix.Fields.Converters.CheckSumConverter.Convert(msg.CheckSum())), true);

            if (validate)
            {
                msg.Validate();
            }
        }
        public static void FromJson
            (JsonElement jsonElement, string beginString, 
            string msgType, IFieldMapSpec msgMap, IMessageFactory msgFactory, 
            DataDictionary dataDict, FieldMap fieldMap)
        {
            foreach (JsonProperty field in jsonElement.EnumerateObject())
            {
                if (dataDict.FieldsByName.TryGetValue(field.Name.ToString(), out DDField ddField))
                {
                    if ((null != msgMap) && (msgMap.IsGroup(ddField.Tag)) && (JsonValueKind.Array == field.Value.ValueKind))
                    {
                        foreach (JsonElement jsonGrp in field.Value.EnumerateArray())
                        {
                            Group grp = msgFactory.Create(beginString, msgType, ddField.Tag);
                            FromJson(jsonGrp, beginString, msgType, msgMap.GetGroupSpec(ddField.Tag), msgFactory, dataDict, grp);
                            fieldMap.AddGroup(grp);
                        }
                    }

                    if (JsonValueKind.Array != field.Value.ValueKind)
                    {
                        fieldMap.SetField(new StringField(ddField.Tag, field.Value.ToString()));
                    }
                }
                else
                {
                    // this may be a custom tag given by number instead of name
                    if (Int32.TryParse(field.Name.ToString(), out int customTagNumber))
                    {
                        fieldMap.SetField(new StringField(customTagNumber, field.Value.ToString()));
                    }
                }
            }
        }
    }


    public class JSONToFIX
    {
        public void JsonMsgToFix(string json, DataDictionary sessionDataDictionary, DataDictionary appDataDictionary, IMessageFactory msgFactory)
        {
            var msg = new Message();
            msg.FromJson(json, true, sessionDataDictionary, appDataDictionary, msgFactory);
            Console.WriteLine(msg.ToString());
        }

        public void JsonToFix(string fname, DataDictionary sessionDataDictionary, DataDictionary appDataDictionary)
        {
            try
            {
                QuickFix.IMessageFactory msgFactory = new QuickFix.DefaultMessageFactory();
                string json = File.ReadAllText(fname);
                using (JsonDocument document = JsonDocument.Parse(json))
                {
                    if (document.RootElement.TryGetProperty("messages", out JsonElement messagesElement))
                    {
                        foreach (JsonElement jsonMsg in messagesElement.EnumerateArray())
                        {
                            JsonMsgToFix(jsonMsg.ToString(), sessionDataDictionary, appDataDictionary, msgFactory);
                        }
                    }
                    else // assume there is only one message instead of an array of messages
                    {
                        JsonMsgToFix(json, sessionDataDictionary, appDataDictionary, msgFactory);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }


    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 1 || args.Length > 2)
            {
                Console.WriteLine("USAGE");
                Console.WriteLine("");
                Console.WriteLine("    FixToJson.exe FILE DATA_DICTIONARY");
                Console.WriteLine("");
                Console.WriteLine("    The FILE may contain either a single message in FIX JSON Encoding, or an array of messages in a root-level \"messages\" element.");
                Console.WriteLine("");
                Console.WriteLine("EXAMPLES");
                Console.WriteLine("");
                Console.WriteLine("    JsonToFix.exe messages.json  ../../spec/fix/FIX50SP2.xml");
                Console.WriteLine("    JsonToFix.exe messages.json ../../spec/fix/FIX44.xml");
                Console.WriteLine("    JsonToFix.exe messages.json ../../spec/fix/FIX42.xml");
                Console.WriteLine("");
                Console.WriteLine("NOTE");
                Console.WriteLine("");
                Console.WriteLine("    Per the FIX JSON Encoding Specification, tags are converted to human-readable form, but values are not.");
                Environment.Exit(2);
            }

            string fname = args[0];
            DataDictionary sessionDataDictionary = new DataDictionary(args[1]);
            DataDictionary appDataDictionary = sessionDataDictionary;
            JSONToFIX j2f = new JSONToFIX();
            j2f.JsonToFix(fname, sessionDataDictionary, appDataDictionary);
            Environment.Exit(1);
        }
    }
}