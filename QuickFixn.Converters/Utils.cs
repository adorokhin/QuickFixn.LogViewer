using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace QuickFixn.Converters
{
	//From Eric White's Blog
	public static class MyExtensions
	{
		public static XElement GetXElement(this XmlNode node)
		{
			XDocument xDoc = new XDocument();
			using (XmlWriter xmlWriter = xDoc.CreateWriter())
				node.WriteTo(xmlWriter);
			return xDoc.Root;
		}

		public static XmlNode GetXmlNode(this XElement element)
		{
			using (XmlReader xmlReader = element.CreateReader())
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(xmlReader);
				return xmlDoc;
			}
		}
	}
	/////////////////////////////////////////////////////////


	public class StreamLimits
	{
		public long startPosition;
		public long endPosition;
        public StreamLimits(long startPosition,  long endPosition)
        {
            this.startPosition = startPosition;
		    this.endPosition = endPosition;
        }
        public override string ToString()
		{
			return String.Format("{0, -12} - {1, -12}", startPosition, endPosition);
		}
	}

	public sealed class Utils
	{

		public static string NormalizeFIXNameSpace(string s)
		{
			s = s.Replace(".", string.Empty);
			if (s.StartsWith("FIXT"))
				s = "FIX50";
			return s;
		}

		public static bool VerifyChecksum(ref string fixMessage, out Tuple<string, string> checksums, bool fixChecksum = false)
		{
			bool result = false;
			string chksRcvStr = null, chksCalcStr = null, msgWOChks = null;
			int chksRcv = 0, chksCalc = -1, chksPos = 0;

			chksPos = fixMessage.LastIndexOf("10=");
			if (chksPos > 0)
			{
				chksRcvStr = fixMessage.Substring(chksPos + 3);
				chksRcvStr = chksRcvStr.TrimEnd('\x01');
				if (int.TryParse(chksRcvStr, out chksRcv))
				{
					msgWOChks = fixMessage.Substring(0, chksPos);
					chksCalc = (msgWOChks.Sum(t => (int)t)) % 256;
					if (chksCalc > 999)
						chksCalcStr = chksCalc.ToString().Substring(0, 3);
					else if (chksCalc < 99)
						chksCalcStr = chksCalc.ToString().PadLeft(3, '0');
					else
						chksCalcStr = chksCalc.ToString();
				}
			}
			checksums = new Tuple<string, string>(chksRcvStr, chksCalcStr);
			result = (chksRcv == chksCalc);
			if (!result && fixChecksum)
				fixMessage = string.Concat(msgWOChks, "10=", chksCalcStr, '\x01'.ToString());
			return result;
		}

		

	}
}
