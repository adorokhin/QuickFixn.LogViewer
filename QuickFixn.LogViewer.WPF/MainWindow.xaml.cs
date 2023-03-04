using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuickFixn.Converters;
using System.Xml.Linq;
using System.Reflection;
using IOPath = System.IO;

/*
 20160620-14:53:42.784 : 8=FIXT.1.19=104535=R34=2449=MA52=20160620-14:53:42.84356=MDGSTAPI131=QuoteReqID-1466434422842-219337146=155=[N/A]48=283483HV022=16360=Education454=1455=US283483HV04456=420200=120201=220202=120203=99.7500000020204=80020205=320206=Unassigned Bonds460=111227=BOND29703=MNPX167=NONE541=20181201225=20061102223=0.05106=EL PASO CNTY COLO SCH DIST NO 49 FALCON GO REF BDS 2006B107=EL PASO CNTY COLO SCH DIST NO 49 FALCON  5.000 12/1/18873=2006110254=238=100000064=2016062315=USD1=TEST660=99581=162=20160620-15:28:00126=20160620-14:58:0060=20160620-14:53:42423=1453=5448=mdgsclt01447=D452=11802=1523=MDGS Client 1803=9448=ML-PEND447=C452=13448=STP Capital Management, Inc.447=D452=13448=MDGS447=C452=17802=1523=0103803=17448=Middlegate Securities Ltd447=D452=1758=RGNL (N/A) requests  offer on $1,000,000 283483HV0, due at 10:58 AM EDT, Multi-Dealers, .5625=220117=36940475961=MNPrice5626=55215=Y5627=Submitted5630=Respond, Pass20120=C2D-RFQ-Open21031=N21032=N20066=369404620067=120013=0.00510=057
true QUOTE_REQUEST Wed Jun 22 09:50:13 EDT 2016 8=FIXT.1.1|9=1028|35=R|34=13|49=MA|52=20160622-13:50:13.812|56=MDGSTAPI|131=QuoteReqID-1466603413812-909515|146=1|55=[N/A]|48=808878FT4|22=1|6360=Health|454=1|455=US808878FT49|456=4|20200=1|20201=2|20202=1|20203=99.00000000|20204=25|20205=3|20206=Unassigned Bonds|460=11|1227=BOND|29703=MNPX|167=NONE|541=20170215|225=20080723|223=0.05|106=SCIOTO CNTY OHIO HOSP FACS REV REF BDS 2008|107=SCIOTO CNTY OHIO HOSP FACS REV REF BDS 2 5.000 2/15/17|873=20080723|54=2|38=2500000|64=20160627|15=USD|1=TEST|660=99|581=1|62=20160622-14:30:00|126=20160622-14:00:00|60=20160622-13:50:13|423=1|453=5|448=mdgsclt01|447=D|452=11|802=1|523=MDGS Client 1|803=9|448=ML-PEND|447=C|452=13|448=STP Capital Management, Inc.|447=D|452=13|448=MDGS|447=C|452=17|802=1|523=0103|803=17|448=Middlegate Securities Ltd|447=D|452=17|58=RGNL (N/A) requests  offer on $2,500,000 808878FT4, due at 10:00 AM EDT, Multi-Dealers, .|5625=2|20117=3698054|5961=MNPrice|5626=5|5215=Y|5627=Submitted|5630=Respond, Pass|20120=C2D-RFQ-Open|21031=N|21032=N|20066=3698053|20067=1|20013=0.003|10=086|
*/

namespace QuickFixn.LogViewer.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private string sFIXDictionary; // = @"..\..\..\Dictionary\FIX50SP2.xml";
        FIXConverter fixConv;
        public MainWindow()
        {
            sFIXDictionary = Properties.Settings.Default.sFIXDictionary;

            InitializeComponent();
            fixConv = FIXConverter.CreateInstance(sFIXDictionary);
            txtDictionaryInUse.Text = sFIXDictionary;
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return IOPath.Path.GetDirectoryName(path);
            }
        }

        private string currConvertedFileName;

        private void DumpXMLToFile(string sXML)
        {
            if (sXML != null)
                sXML = sXML.Trim();
            if (string.IsNullOrEmpty(sXML))
                return;

            var fileName = DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".xml";
            var filePath = IOPath.Path.Combine(AssemblyDirectory, "Converted", fileName);
            System.IO.File.WriteAllText(filePath, sXML);

            var rootPath = IOPath.Path.GetPathRoot(filePath);
            var dir = IOPath.Path.GetDirectoryName(filePath);

            currConvertedFileName = filePath.Replace(rootPath, "\\\\127.0.0.1\\C$\\");

        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string s = string.Empty;

            var ischkbDumpXML = (chkbDumpXMLToFile.IsChecked.HasValue && (chkbDumpXMLToFile.IsChecked.Value == true));

            try
            {
                int lineCount = input.LineCount;
                if (lineCount <= 0)
                    return;
                if (ischkbDumpXML)
                    sb.Append("<!--saved from url = (0016)http://localhost -->");
                sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                sb.Append("<Log>");
                for (int lineNo = 0; lineNo < lineCount; lineNo++)
                {
                    s = input.GetLineText(lineNo);
                    s = s.Replace('|', '\x01');
                    s = s.TrimEnd('\r');
                    s = s.TrimEnd('\n');
                    s = s.Trim();
                    if (!(string.IsNullOrEmpty(s)) && !(s.StartsWith("#")))
                    {
                        XElement xe = fixConv.BuildXMLFromString(s);
                        sb.Append(xe.ToString());
                    }
                }
                sb.Append("</Log>");

                if (ischkbDumpXML)
                {
                    DumpXMLToFile(sb.ToString());
                    this.webBrowser.Navigate("file:///" + currConvertedFileName);
                }
                else
                    this.webBrowser.NavigateToString(sb.ToString());
            }
            catch (Exception ex)
            {
                try
                {
                    this.webBrowser.NavigateToString(ex.FeedFormatExceptionHTML("Failed to process line: " + s));
                }
                catch { }

            }
        }

        private void btnLoadDictionary_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = AssemblyDirectory;
            dlg.DefaultExt = ".xml";
            dlg.Filter = "FIX Dictionary Files (*.xml)|*.xml|All Files (*.*)|*.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                try
                {
                    sFIXDictionary = dlg.FileName;
                    FIXConverter.LoadDictionary(sFIXDictionary);
                    txtDictionaryInUse.Text = sFIXDictionary;
                }
                catch (Exception ex)
                {
                    this.webBrowser.NavigateToString(ex.FeedFormatExceptionHTML($"Failed to load dictionary: {sFIXDictionary}"));
                }
            }
        }
    }
}
