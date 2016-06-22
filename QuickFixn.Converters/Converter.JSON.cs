using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuickFix.Fields;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuickFixn.Converters
{
    public partial class FIXConverter
    {
        public string BuildJSONFromString(string s, bool validateMsg = false, bool correctChks = true)
        {
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
            XElement xElem = BuildXML(msg, msgType, logTimeStamp, sOrigChks);
            string jsonText = JsonConvert.SerializeXmlNode(xElem.GetXmlNode());
            //=================================================================
            return jsonText;

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

        public string BuildJSON(QuickFix.Message msg, MsgType msgType, DateTime? logTimeStamp = null, string origChkSum = null)
        {
            ////Debug.WriteLine(" ~~~> " + msg.GetType().ToString());
            //SessionID sessionID = msg.GetSessionID(msg);

            //FIXClassInfo fixClass = null;
            //if (msg.GetType() == typeof(QuickFix.Message))
            //{
            //    var classes = fixClasses[msgType.ToString(), Utils.NormalizeFIXNameSpace(sessionID.BeginString)];
            //    if (classes != null && classes.Count > 0)
            //        fixClass = classes[0];
            //}

            ////var root = new XElement(msg.GetType().ToString());
            //var root = new XElement((fixClass != null) ? fixClass.type.FullName : msg.GetType().ToString());
            //root.Add(new XAttribute("MessageType", msgType.ToString()));
            //root.Add(new XAttribute("Session", sessionID.ToString()));
            //if (logTimeStamp.HasValue)
            //    root.Add(new XAttribute("LogTimeStamp", logTimeStamp.Value));

            //var header = new XElement(msg.Header.GetType().ToString());
            //ProcessFieldMapToXML(header, msg.Header);
            //root.Add(header);

            //var body = new XElement(msg.GetType().ToString() + ".Body");
            //ProcessFieldMapToXML(body, msg);
            //root.Add(body);

            //var trailer = new XElement(msg.Trailer.GetType().ToString());
            //ProcessFieldMapToXML(trailer, msg.Trailer, origChkSum);
            //root.Add(trailer);

            //return root;
            return "";
        }

        //private void ProcessFieldMapToXML(XElement parent, FieldMap fieldMap, string origChkSum = null)
        //{
        //    Type fieldType;
        //    XElement child = null;
        //    foreach (var field in fieldMap)
        //    {
        //        if (dataDictionary.TryGetFieldType(field.Key, out fieldType))
        //        {
        //            FIXDictionary.DDField ddField = dataDictionary.FieldsByTag[field.Key];
        //            child = new XElement(ddField.Name);
        //            child.Add(new XAttribute("Tag", field.Key));
        //            child.Add(new XAttribute("Value", field.Value));
        //            if (ddField.HasEnums())
        //            {
        //                child.Add(new XAttribute("HasEnums", true));
        //                string enumTranslation = ddField.EnumDict.FirstOrDefault(t => t.Key == field.Value.ToString()).Value;
        //                if (!string.IsNullOrEmpty(enumTranslation))
        //                    child.Add(new XAttribute("EnumTranslation", enumTranslation));
        //            }

        //            if (field.Key == Tags.CheckSum && origChkSum != null)
        //            {
        //                child.Add(new XAttribute("OrigChks", origChkSum));
        //            }

        //            int groupCount = fieldMap.GroupCount(field.Key);

        //            if (groupCount > 0)
        //            {
        //                child.Add(new XAttribute("IsGroup", "Y"));
        //                child.Add(new XAttribute("GroupsCount", groupCount));

        //                for (int i = 1; i <= groupCount; i++)
        //                {
        //                    Group currGroup = fieldMap.GetGroup(i, field.Key);
        //                    ProcessFieldMapToXML(child, currGroup);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            child = new XElement("UserDefined_" + field.Key.ToString());
        //            child.Add(new XAttribute("Tag", field.Key));
        //            child.Add(new XAttribute("Value", field.Value));
        //        }
        //        parent.Add(child);
        //    }
        //}

    }
}
