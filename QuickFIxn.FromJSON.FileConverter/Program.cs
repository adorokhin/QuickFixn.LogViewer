using System;
using QuickFix.DataDictionary;

namespace QuickFIXn.JSON.FileConverter
{


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