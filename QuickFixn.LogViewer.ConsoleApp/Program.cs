using QuickFixn.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Linq;
using FIXDictionary = QuickFix.DataDictionary;

namespace QuickFixn.LogViewer.ConsoleApp
{
	class Program
	{

		private const string sFIXDictionary = @"C:\DEV\FIX\QuickFixn.LogViewer\Dictionary\FIX50SP2.xml";

		private static void Test1()
		{
			List<string> testData = new List<string>
			{
				@"8=FIX.4.29=6335=A49=FABKOM56=WEDB34=98352=20160328-18:25:4298=0108=3010=128",
				@"8=FIX.4.29=6635=234=34349=WEDB52=20160328-18:25:44.12556=FABKOM7=92316=010=001",
				@"8=FIX.4.29=6935=449=FABKOM56=WEDB52=20160328-18:25:4434=92343=Y123=Y36=98410=211",
				@"8=FIX.4.29=5135=049=FABKOM56=WEDB34=98452=20160328-18:26:1210=082",
				@"8=FIX.4.29=5535=034=34449=WEDB52=20160328-18:26:14.95856=FABKOM10=034",
				@"8=FIX.4.29=6135=149=FABKOM56=WEDB34=98552=20160328-18:26:19112=HELLO10=162",
				@"8=FIX.4.29=6535=034=34549=WEDB52=20160328-18:26:22.95856=FABKOM112=HELLO10=105",
				@"8=FIX.4.29=6335=A49=FABKOM56=WEDB34=98752=20160328-18:27:3098=0108=3010=131",
				@"8=FIX.4.29=6735=A34=34749=WEDB52=20160328-18:27:30.69456=FABKOM98=0108=3010=078",
				@"8=FIX.4.29=6635=234=34849=WEDB52=20160328-18:27:30.69456=FABKOM7=98616=010=023",
				@"8=FIX.4.29=6935=449=FABKOM56=WEDB52=20160328-18:27:3034=98643=Y123=Y36=98810=221",
				@"8=FIXT.1.19=091735=849=BLPSTP56=JEFFMATTSTP34=3626347=UTF-852=20160504-18:31:1060=20160504-18:31:10150=F31=100151=0541=2026021932=100000423=164=201605066=10037=VCON:20160504:50357:5157=7438=10000039=2159=709.17669=100460=3223=0.034514=10000015=USD75=20160504106=IBM CORP17=VCON:20160504:50357:5:12167=CORP48=459200JG7198=3739:20160504:50357:5470=US381=10000022=154=17014=2155=[N/A]236=0.034495675118=100709.17453=6448=9001447=D452=1448=14112330447=D452=11802=5523=14803=4523=JEFF DOLGOS803=9523=SAFETY HARBOR803=34523=US803=38523=13182636803=4000448=6204326447=D452=12802=3523=EVAN HOFFMAN803=9523=NEW YORK803=34523=US803=38448=JEFFREY MATTHEWS FINL GROUP, LLC.447=D452=13448=SXT447=D452=16448=6204326447=D452=36802=3523=EVAN HOFFMAN803=9523=NEW YORK803=34523=US803=38454=4455=US459200JG74456=4455=459200JG7456=1455=JK138051456=A455=IBM456=810=118"
			};

			FIX2XMLConverter f2xc = FIX2XMLConverter.CreateInstance(sFIXDictionary);

			foreach (var s in testData)
			{
				XElement xe = f2xc.BuildXMLFromString(s);
				Debug.WriteLine(xe.ToString());
				Debug.WriteLine(new string('-', 80));
			}
		}


		private static void Test2()
		{
			string testDataFileName = @"C:\DEV\FIX\QuickFixn.LogViewer\TestData\FIX.4.4-FABKOM_TO_RBC-RBC_TO_FABKOM.messages.current.log";

			FIX2XMLConverter f2xc = FIX2XMLConverter.CreateInstance(sFIXDictionary);

			var sw = Stopwatch.StartNew();
			
			const Int32 BufferSize = 16384;
			int counter = 0, err_counter = 0;
			FileInfo f = new FileInfo(testDataFileName);
			long fileSize = f.Length;
			
			using (var fileStream = File.OpenRead(testDataFileName))
			using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
			{
				string line;
				while ((line = streamReader.ReadLine()) != null)
				{
					try
					{
						sw.Stop();
						Console.SetCursorPosition(0, 0);
						Console.WriteLine(string.Format("Line: {0, 10}  {1}%", counter++, ((fileStream.Position/(fileSize*1.0))*100).ToString("F3")));
						sw.Start();

						
						XElement xe = f2xc.BuildXMLFromString(line);
					}
					catch(Exception ex)
					{
						err_counter++;
						Debug.WriteLine("");
						Debug.WriteLine(new string('!', 80));
						Debug.WriteLine(line);
						Debug.WriteLine(new string('-', 80));
						Debug.WriteLine(ex.ToString());
						Debug.WriteLine(new string('!', 80));
						Debug.WriteLine("");
					}
					//Debug.WriteLine(xe.ToString());
					//Debug.WriteLine(new string('-', 80));
				}
			}
			sw.Stop();
			Console.WriteLine(string.Format("Processed: {0} records in {1} sec. Errors: [{2}]  ", counter, sw.ElapsedMilliseconds / 1000.00, err_counter));
			Console.WriteLine(string.Format("Avg Speed: {0}  Rec./sec.", (counter * 1.0 / (sw.ElapsedMilliseconds / 1000)).ToString("F3")));
		}

		static void Main(string[] args)
		{

			//Test1();
			Test2();
			Console.WriteLine("Done!");
			Console.ReadKey();
		}
	}
}
