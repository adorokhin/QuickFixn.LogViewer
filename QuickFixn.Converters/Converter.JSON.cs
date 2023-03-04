using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuickFix;
using QuickFix.Fields;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FIXDictionary = QuickFix.DataDictionary;

namespace QuickFixn.Converters
{
    public partial class FIXConverter
    {
        public string BuildJSONFromString(string s, bool validateMsg = false, bool correctChks = true)
        {
            string sJSON = string.Empty;
            DateTime? logTimeStamp = null;
            int fixStart = s.IndexOf("8=FIX");
            if (fixStart > 0)
            {
                string dateString = s.Substring(0, fixStart - 1);
                dateString = dateString.TrimEnd('\x01', ':', ' ');
                string format = "yyyyMMdd-HH:mm:ss.fff";
                DateTime dateTime;
                if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                    logTimeStamp = dateTime;
                s = s.Substring(fixStart);
            }

            var msg = new QuickFix.Message();

            var chksTuple = new Tuple<string, string>(string.Empty, string.Empty);
            string sOrigChks = null;
            if (correctChks)
            {
                if (!Utils.VerifyChecksum(ref s, out chksTuple, fixChecksum: true))
                    sOrigChks = chksTuple.Item1;
            }

            //---------------------------------------------------------------------------------------
            msg.FromString(s, validateMsg, sessionDataDictionary, dataDictionary, messageFactory);
            //---------------------------------------------------------------------------------------


            MsgType msgType = QuickFix.Message.IdentifyType(s);
            //Very inefficient. Need to rewrite to build JSON myself.
            sJSON = BuildJSON(msg, msgType, logTimeStamp, sOrigChks);
            
            //sJSON = JsonConvert.SerializeObject(msg);
            
            //string sJSON = JsonConvert.SerializeXmlNode(xElem.GetXmlNode());
            //XElement xElem = BuildXML(msg, msgType, logTimeStamp, sOrigChks);
            //=================================================================
            return sJSON;

            //JTokenWriter writer = new JTokenWriter();
            //writer.WriteStartObject();
            //writer.WritePropertyName("name1");
            //writer.WriteValue("value1");
            //writer.WritePropertyName("name2");
            //writer.WriteStartArray();
            //writer.WriteValue(1);
            //writer.WriteValue(2);
            //writer.WriteEndArray();
            //writer.WriteEndObject();

            //JObject o = (JObject)writer.Token;

            //return o.ToString();
        }

        /*
        {
            "glossary": {
                "title": "example glossary",
		        "GlossDiv": {
                    "title": "S",
			        "GlossList": {
                        "GlossEntry": {
                            "ID": "SGML",
					        "SortAs": "SGML",
					        "GlossTerm": "Standard Generalized Markup Language",
					        "Acronym": "SGML",
					        "Abbrev": "ISO 8879:1986",
					        "GlossDef": {
                                "para": "A meta-markup language, used to create markup languages such as DocBook.",
						        "GlossSeeAlso": ["GML", "XML"]
                            },
					        "GlossSee": "markup"
                        }
                    }
                }
            }
        }         
        */
        private string FormatJSONPair(string name, string value, int indent = 0)
        {
            var s = $@"{new string(' ', indent)}""{name}"":""{value}""";
            return s;
        }
        private string FormatJSONPair(string name, DateTime? value, int indent = 0)
        {
            var s = string.Empty;
            if (value.HasValue)
                s = $@"{new string(' ', indent)}""{name}"":""{JsonConvert.SerializeObject(value.Value)}""";
            return s;
        }
        /*
         //Sample
        {
	        "QuickFix.FIX44.ExecutionReport": {
            "MessageType":"QuickFix.FIX44.ExecutionReport",
            "Session":"FIX.4.4:BLP->MAP_GPSE_PRD",
            "LogTimeStamp":"2019-10-09T14:25:34.187Z",
            "Header": {
            }
	    }
}     
        */

        public string BuildJSON(QuickFix.Message msg, MsgType msgType, DateTime? logTimeStamp = null, string origChkSum = null)
        {
            //JObject jo = JObject.FromObject(fixMsg);
            //jo.Add("feeClass", "A");
            //string sJSON = jo.ToString();
            

            ////Debug.WriteLine(" ~~~> " + msg.GetType().ToString());
            SessionID sessionID = msg.GetSessionID(msg);

            FIXClassInfo fixClass = null;
            if (msg.GetType() == typeof(QuickFix.Message))
            {
                var classes = fixClasses[msgType.ToString(), Utils.NormalizeFIXNameSpace(sessionID.BeginString)];
                if (classes != null && classes.Count > 0)
                    fixClass = classes[0];
            }

            StringBuilder sb = new StringBuilder();
            var root = (fixClass != null) ? fixClass.type.FullName : msg.GetType().ToString();
            sb.Append("{");
            sb.Append($@"""{root}"":");
            sb.Append(FormatJSONPair("MessageType", msg.GetType().ToString()));
            sb.Append(FormatJSONPair("Session", sessionID.ToString()));
            sb.Append(FormatJSONPair("LogTimeStamp", logTimeStamp));

            ProcessFieldMapToJSON("Header", sb, msg.Header);
            ProcessFieldMapToJSON("Body", sb, msg);
            ProcessFieldMapToJSON("Trailer", sb, msg.Trailer, origChkSum);

            sb.Append("}");
            sb.Append("}");

            return sb.ToString();
        }

        private void ProcessFieldMapToJSON(string sNode, StringBuilder sb, FieldMap fieldMap, string origChkSum = null)
        {
            Type fieldType;
            sb.Append($@"""{sNode}"":");

            foreach (var field in fieldMap)
            {
                if (dataDictionary.TryGetFieldType(field.Key, out fieldType))
                {
                    FIXDictionary.DDField ddField = dataDictionary.FieldsByTag[field.Key];
                    child = new XElement(ddField.Name);
                    child.Add(new XAttribute("Tag", field.Key));
                    child.Add(new XAttribute("Value", field.Value));
                    if (ddField.HasEnums())
                    {
                        child.Add(new XAttribute("HasEnums", true));
                        string enumTranslation = ddField.EnumDict.FirstOrDefault(t => t.Key == field.Value.ToString()).Value;
                        if (!string.IsNullOrEmpty(enumTranslation))
                            child.Add(new XAttribute("EnumTranslation", enumTranslation));
                    }

                    if (field.Key == Tags.CheckSum && origChkSum != null)
                    {
                        child.Add(new XAttribute("OrigChks", origChkSum));
                    }

                    int groupCount = fieldMap.GroupCount(field.Key);

                    if (groupCount > 0)
                    {
                        child.Add(new XAttribute("IsGroup", "Y"));
                        child.Add(new XAttribute("GroupsCount", groupCount));

                        for (int i = 1; i <= groupCount; i++)
                        {
                            Group currGroup = fieldMap.GetGroup(i, field.Key);
                            ProcessFieldMapToXML(child, currGroup);
                        }
                    }
                }
                else
                {
                    child = new XElement("UserDefined_" + field.Key.ToString());
                    child.Add(new XAttribute("Tag", field.Key));
                    child.Add(new XAttribute("Value", field.Value));
                }
                parent.Add(child);
            }
            sb.Append("}");
        }

    }
}
