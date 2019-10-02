using QuickFix;
using QuickFix.Fields;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using FIXDictionary = QuickFix.DataDictionary;

namespace QuickFixn.Converters
{
	public class FIXClassInfo
	{
		public string nameSpace;
		public string className;
		public string msgType;
		public Type type;
		
		public override string ToString()
		{
			return $@"{nameSpace}.{className } MsgType=""{msgType}""";
		}
	}

	public class FIXClassesInfo
	{
		public List<FIXClassInfo> classesList = new List<FIXClassInfo>();
		
		public static FIXClassesInfo Instance = null;
		public static FIXClassesInfo CreateInstance()
		{
			if (Instance == null)
				Instance = new FIXClassesInfo();
			return Instance;
		}

		public void LoadQuickFIXTypesInfo(string nameSpace)
		{
			//@"QuickFix, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null";
			//public const string MsgType = "8";
			var assemblyName = Assembly.GetExecutingAssembly().GetReferencedAssemblies().Where(t => t.FullName.ToLower().StartsWith("quickfix")).ToList();
			Assembly assembly = Assembly.Load(assemblyName[0]);
			var types = assembly.GetTypes().Where((t) => !string.IsNullOrEmpty(t.Namespace) && t.Namespace.ToLower().StartsWith(nameSpace.ToLower())).ToList();
			if ((types == null) || (types.Count == 0))
				throw new Exception("Failed to get types from QuickFix.dll");
			
			foreach (var type in types)
			{
				var publicFields = type.GetFields();
				FieldInfo fieldInfo = type.GetField("MsgType");
				if (fieldInfo != null)
				{
					string msgType = fieldInfo.GetRawConstantValue().ToString();
					classesList.Add(new FIXClassInfo { nameSpace = type.Namespace, className = type.Name, msgType = msgType, type = type });

					//Debug.WriteLine(string.Format("==> [{0}] [{1}] [{2}] [{3}] type = [{4}]", type.Namespace, type.Name, fieldInfo.Name, fieldInfo.GetRawConstantValue().ToString(), type.ToString()));
				}
			}

		}

		public List<FIXClassInfo> this[string msgType, string fixNamespace]
		{
			get
			{
				var result =  classesList.Where(t=>t.msgType == msgType && t.nameSpace.EndsWith(fixNamespace)).ToList();
				return result;

			}
			private set
			{
				throw new NotImplementedException("FIXClassesInfo indexer SET not implemented.");
			}
		}

	}

	//[Flags]
	// public enum MessagingProperties
	//{
	//      None = 0x00,
	//      Durable = 0x01,
	//      Persistent = 0x02,
	//      Buffered = 0x04
	//}
	
	public partial class FIXConverter
	{
		[ThreadStatic]
		private static FIXConverter Instance = null;

		#region [Singleton]
		private FIXConverter() { }
		public static FIXConverter CreateInstance(string sFIXDictionary)
		{
			if (Instance == null)
			{
				Instance = new FIXConverter();

				if(!string.IsNullOrEmpty(sFIXDictionary))
				{
					dataDictionary = new FIXDictionary.DataDictionary();
					dataDictionary.Load(sFIXDictionary);
				}
				
				fixClasses = FIXClassesInfo.CreateInstance();
				fixClasses.LoadQuickFIXTypesInfo("QuickFix.FIX");
			}
			return Instance;
		}
		#endregion

		#region [Fields]
		private static FIXDictionary.DataDictionary dataDictionary = null;
		private static FIXDictionary.DataDictionary sessionDataDictionary = null;
		private static IMessageFactory messageFactory = new DefaultMessageFactory();
		private static FIXClassesInfo fixClasses = null;
		#endregion

		#region [Properties]
		private bool _IncludeDebugAttributes = false;

		public bool IncludeDebugAttributes
		{
			get { return _IncludeDebugAttributes; }
			set { _IncludeDebugAttributes = value; }
		}
		#endregion

		public static void LoadDictionary(string sFIXDictionary)
		{
			if (!string.IsNullOrEmpty(sFIXDictionary))
			{
				dataDictionary = new FIXDictionary.DataDictionary();
				dataDictionary.Load(sFIXDictionary);
			}
		}

		public XElement BuildXMLFromString(string s, bool validateMsg = false, bool correctChks=true)
		{
			//"20150611-21:29:27.811 :"
			//8=FIX

			if (string.IsNullOrEmpty(s))
				return null;

			if (s != null)
				s = s.Trim();


			DateTime? logTimeStamp = null;
			int fixStart = s.IndexOf("8=FIX");
			if (fixStart > 0)
			{
				string dateString = s.Substring(0, fixStart-1);
				dateString = dateString.TrimEnd('\x01', ':', ' ');
				string format = "yyyyMMdd-HH:mm:ss.fff";
				DateTime dateTime;
				if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture,  DateTimeStyles.None, out dateTime))
					logTimeStamp = dateTime;
				s = s.Substring(fixStart);
			}

			
			var msg = new QuickFix.Message();
			s = s.Trim('\n');
			s = s.Trim('\r');
			//msg.FromString(s, false, dataDictionary, dataDictionary, messageFactory);
			
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
			return BuildXML(msg, msgType, logTimeStamp, sOrigChks);
		}

		public XElement BuildXML(QuickFix.Message msg,  MsgType msgType, DateTime? logTimeStamp = null, string origChkSum = null)
		{
			//Debug.WriteLine(" ~~~> " + msg.GetType().ToString());
			SessionID sessionID = msg.GetSessionID(msg);

			FIXClassInfo fixClass = null;
			if (msg.GetType() == typeof(QuickFix.Message))
			{
				var classes = fixClasses[msgType.ToString(), Utils.NormalizeFIXNameSpace(sessionID.BeginString)];
				if(classes != null && classes.Count>0)
					fixClass = classes[0];
			}

			//var root = new XElement(msg.GetType().ToString());
			var root = new XElement((fixClass!=null) ? fixClass.type.FullName : msg.GetType().ToString());
			root.Add(new XAttribute("MessageType", msgType.ToString()));
			root.Add(new XAttribute("Session", sessionID.ToString()));
			if(logTimeStamp.HasValue)
				root.Add(new XAttribute("LogTimeStamp", logTimeStamp.Value));	
			
			var header = new XElement(msg.Header.GetType().ToString());
			ProcessFieldMapToXML(header, msg.Header);
			root.Add(header);
			
			var body = new XElement(msg.GetType().ToString() + ".Body");
			ProcessFieldMapToXML(body, msg);
			root.Add(body);
			
			var trailer = new XElement(msg.Trailer.GetType().ToString());
			ProcessFieldMapToXML(trailer, msg.Trailer, origChkSum);
			root.Add(trailer);
			
			return root;
		}

		private void ProcessFieldMapToXML(XElement parent, FieldMap fieldMap, string origChkSum=null)
		{
			Type fieldType;
			XElement child = null;
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
						if(!string.IsNullOrEmpty(enumTranslation))
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
					child = new XElement("UserDefined_"+field.Key.ToString());
					child.Add(new XAttribute("Tag", field.Key));
					child.Add(new XAttribute("Value", field.Value));
				}
				parent.Add(child);
			}
		}
	}
}

