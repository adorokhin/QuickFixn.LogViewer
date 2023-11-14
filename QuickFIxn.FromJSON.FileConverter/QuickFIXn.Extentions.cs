using System;
using System.Text.Json;
using QuickFix;
using QuickFix.DataDictionary;
using QuickFix.Fields;

namespace QuickFIXn.JSON.FileConverter
{
    public static class QuickFIXnExtentions
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
}