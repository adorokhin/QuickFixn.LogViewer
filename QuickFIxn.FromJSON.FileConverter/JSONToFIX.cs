using System;
using System.IO;
using System.Text.Json;
using QuickFix;
using QuickFix.DataDictionary;

namespace QuickFIXn.JSON.FileConverter
{
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
}