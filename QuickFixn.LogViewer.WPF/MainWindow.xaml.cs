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
using System.Diagnostics;
using IOPath = System.IO;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.CodeDom;
using System.Windows.Markup;
using System.IO;

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
        private string FIXDictionaryFile; // = @"..\..\..\Dictionary\FIX50SP2.xml";
        FIXConverter fixConv;
        private ImageBrush textImageBrush = new ImageBrush();
        private const char FIXSeparator = '◆';
        private const char SOH = '\x01';
        private const char NoBreakSpace = '\xA0';
        private readonly Brush separatorBrush = Brushes.LightGray;


        int GetLineLength(RichTextBox box, int lineNumber)
        {
            int currentLine = 0;
            foreach (var paragraph in box.Document.Blocks.OfType<Paragraph>())
            {
                foreach (var text in paragraph.Inlines.OfType<Run>())
                {
                    ++currentLine;
                    if (currentLine == lineNumber)
                        return text.Text.Length;
                };
            };
            //int paragraphNumber = box.Document.Blocks.Count(x => x is Paragraph);
            return -1;
        }

        //int GetLineLength(RichTextBox box, int lineNumber)
        //{
        //    var range = new TextRange(box.Document.ContentStart, box.Document.ContentEnd);
        //    var lines = range.Split('\n');

        //    return (lines.Length >= lineNumber) ? lines[lineNumber - 1] : -1;
        //}

        private void SetInputImageBrush()
        {
            textImageBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Graphics/TextBoxInputBackground.png"));
            textImageBrush.AlignmentX = AlignmentX.Center;
            textImageBrush.Stretch = Stretch.Fill;
        }

        public MainWindow()
        {
            FIXDictionaryFile = Properties.Settings.Default.FIX_Dictionary;

            SetInputImageBrush();

            InitializeComponent();

            rtbInput.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            rtbInput.Document.PageWidth = 2000;
            rtbInput.AutoWordSelection = false;
            //LoadRichTextBox("");

            fixConv = FIXConverter.CreateInstance(FIXDictionaryFile);
            txtDictionaryInUse.Text = FIXDictionaryFile;

            DisplayAssemblyInfo();

            //rtbInput.TextInput += (o, i) =>
            //{
            //    MessageBox.Show(i.Text, "rtbInput::OnTextInput", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            //};


            RandomPastelColorGenerator colors = new RandomPastelColorGenerator();
            var brush = colors.GetNextBrush();
            //var color = brush.Color;
            var FieldTagColors = new Dictionary<int, Brush>();

            foreach (KeyValuePair<int, QuickFix.DataDictionary.DDField> field in FIXConverter.DictionaryFields)
            {
                FieldTagColors.Add(field.Key, colors.GetNextBrush());
            }

            ColorsTester.GenerateHtml(FieldTagColors);

            //Get all FIX Record Types from Dictionary.
            //Assign Basic Starting Color to each Record Type
            //Assigh Colors to Components?
            //Assign Colors to Fields?
            //If Record Type is not in current Dictionary - display it with reddish color
            //If Field tag is not in dictionaty - display it with reddish color/background.

            var FIXFields = FIXConverter.DictionaryFields;
            //FIXConverter.GetFieldsForRecord("Header")

            /*
             * 
             * 
             MessageGroup
            INSERT INTO MessageGroup(MsgGroup) VALUES ()
            'Session','PreTrade', 'Trade', 'PostTrade', 'Infrastructure'



Application
BusinessReject
Network
UserManagement

Session
    Session
    Heartbeat
    Logon
    Logout
    Reject
    ResendRequest
    SequenceReset
    TestRequest
    XMLnonFIX
PreTrade
    Indication
    EventCommunication
    QuotationNegotiation
    MarketData
    MarketStructureReferenceData
    SecuritiesReferenceData
    PartiesReferenceData
    PartiesAction
Trade
    SingleGeneralOrderHandling
    ProgramTrading
    OrderMassHandling
    CrossOrders
    MultilegOrders
PostTrade
    Allocation
    SettlementInstruction
    RegistrationInstruction
    TradeCapture
    Confirmation
    PositionMaintenance
    CollateralManagement
    MarginRequirementManagement
    AccountReporting
    TradeManagement
    PayManagement
    SettlementStatusManagement
Infrastructure
    Application
    BusinessReject
    Network
    UserManagement

             * */




        }



        private void DisplayAssemblyInfo()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            //Version version = Assembly.GetEntryAssembly().GetName().Version;
            Version assemblyVer = assembly.GetName().Version;
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string fileVer = fvi.FileVersion;
            txtAssemblyVersion.Text = $"A:{assemblyVer} F:{fileVer}";
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

        private bool GetInputLines(StringCollection col)
        {
            col = col ?? new StringCollection();
            var textRange = new TextRange(rtbInput.Document.ContentStart, rtbInput.Document.ContentEnd);
            string rawInput = textRange.Text;
            var lines = rawInput.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            col.AddRange(lines);
            return true;

        }

        private string AssembleFixLines(string input)
        {
            StringBuilder assembled = new StringBuilder();
            StringBuilder currentLine = new StringBuilder();

            var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                currentLine.Append(line);

                if (Regex.IsMatch(currentLine.ToString(), @"10=\d{1,3}\x01"))
                {
                    assembled.AppendLine(currentLine.ToString());
                    currentLine.Clear();
                }
            }

            // Handle any remaining content.
            if (currentLine.Length > 0)
            {
                assembled.Append(currentLine.ToString());
            }

            return assembled.ToString();
        }
        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string s = string.Empty;

            var ischkbDumpXML = (chkbDumpXMLToFile.IsChecked.HasValue && (chkbDumpXMLToFile.IsChecked.Value == true));
            //var textRange = new TextRange(input.Document.ContentStart, input.Document.ContentEnd);
            //string rawInput = textRange.Text;
            //string assembledInput = AssembleFixLines(rawInput);
            StringCollection inputStrings = new StringCollection();
            _ = GetInputLines(inputStrings);


            //var textRange = new TextRange(rtbInput.Document.ContentStart, rtbInput.Document.ContentEnd);
            //string rawInput = textRange.Text;
            //textRange.Text = rawInput.Replace(SOH, FIXSeparator);
            
            //            public static class RichTextBoxExtensions
            //        {
            //            public static void AppendText(this RichTextBox box, string text, Color color)
            //            {
            //                box.SelectionStart = box.TextLength;
            //                box.SelectionLength = 0;

            //                box.SelectionColor = color;
            //                box.AppendText(text);
            //                box.SelectionColor = box.ForeColor;
            //            }
            //        }
            //        And this is how you would use it:


            //        var userid = "USER0001";
            //        var message = "Access denied";
            //        var box = new RichTextBox
            //              {
            //                  Dock = DockStyle.Fill,
            //                  Font = new Font("Courier New", 10)
            //              };

            //    box.AppendText("[" + DateTime.Now.ToShortTimeString() + "]", Color.Red);
            //box.AppendText(" ");
            //box.AppendText(userid, Color.Green);
            //box.AppendText(": ");
            //box.AppendText(message, Color.Blue);
            //box.AppendText(Environment.NewLine);

            //new Form {Controls = {box
            //}}.ShowDialog();


            try
            {
                //int lineCount = input.LineCount;
                //if (lineCount <= 0)
                //    return;

                if (inputStrings.Count <= 0)
                    return;


                sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                if (ischkbDumpXML)
                    sb.AppendLine("<!--saved from url = (0016)http://localhost -->");
                sb.AppendLine("<Log>");
                //-- input.GetLineLength

                //for (int lineNo = 0; lineNo < lineCount; lineNo++)
                foreach (var inputString in inputStrings)
                {
                    var line = inputString.Trim();

                    if (string.IsNullOrEmpty(line))
                        continue;
                    if (line.StartsWith("#"))
                        continue;
                    if (!line.Contains(SOH))
                    {
                        line = line.Replace('|', SOH);
                        line = line.Replace(FIXSeparator, SOH);
                    }

                    XElement xe = fixConv.BuildXMLFromString(line);
                    sb.Append(xe.ToString());

                    //    s = s.Replace('|', '\x01');
                    //    s = input.GetLineText(lineNo);
                    //    if (!s.Contains('\x01'))
                    //        s = s.Replace('|', '\x01');
                    //    s = s.TrimEnd('\r');
                    //    s = s.TrimEnd('\n');
                    //    s = s.Trim();
                    //    if (!(string.IsNullOrEmpty(s)) && !(s.StartsWith("#")))
                    //    {
                    //        XElement xe = fixConv.BuildXMLFromString(s);
                    //        sb.Append(xe.ToString());
                    //    }
                    //}
                }
                sb.AppendLine("</Log>");

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

        //private static void UpdateSetting(string key, string value)
        //{
        //    Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    configuration.AppSettings.Settings[key].Value = value;
        //    configuration.Save();

        //    ConfigurationManager.RefreshSection("appSettings");
        //}

        private void btnLoadDictionary_Click(object sender, RoutedEventArgs e)
        {

            var dictPath = System.IO.Path.GetDirectoryName(FIXDictionaryFile);
            var initialDir = Directory.Exists(dictPath) ? dictPath : AssemblyDirectory;
            
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                InitialDirectory = initialDir,
                DefaultExt = ".xml",
                Filter = "FIX Dictionary Files (*.xml)|*.xml|All Files (*.*)|*.*"
            };
            
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                try
                {
                    FIXDictionaryFile = dlg.FileName;
                    FIXConverter.LoadDictionary(FIXDictionaryFile);
                    txtDictionaryInUse.Text = FIXDictionaryFile;
                }
                catch (Exception ex)
                {
                    this.webBrowser.NavigateToString(ex.FeedFormatExceptionHTML($"Failed to load dictionary: {FIXDictionaryFile}"));
                }
            }
        }

        private bool busyUpdating = false;

        private void OnRTBTextBoxInputTextChanged(object sender, TextChangedEventArgs e)
        {

          if (busyUpdating)
                return;

            if (!(sender is RichTextBox rtb))
                return;

            TextPointer contentStart = rtb.Document.ContentStart;
            TextPointer contentEnd = rtb.Document.ContentEnd;

            try
            {
                var textRange = new TextRange(contentStart, contentEnd);

                if (string.IsNullOrEmpty(textRange.Text))
                {
                    rtbInput.Background = textImageBrush;
                    return;
                }
                else
                {
                    if (rtbInput.Background != Brushes.White)
                        rtbInput.Background = Brushes.White;
                }

                //var paragraphNumber = rtb.Document.Blocks.Count(x => x is Paragraph);

                //var commentLineBrush = new SolidColorBrush(Colors.Red);

                busyUpdating = true;

                foreach (var paragraph in rtb.Document.Blocks.OfType<Paragraph>())
                {
                    var run = paragraph.Inlines.OfType<Run>().FirstOrDefault() ?? new Run();
                    if (run.Text.Trim().StartsWith("#"))
                    {
                        if (paragraph.Foreground != Brushes.DarkGreen)
                            paragraph.Foreground = Brushes.DarkGreen;
                    }
                    else if (paragraph.Foreground == Brushes.DarkGreen)
                    {
                        paragraph.Foreground = Brushes.Black;
                    }

                    //foreach (var text in paragraph.Inlines.OfType<Run>())
                    //{
                    //    if (text.Text.Trim().StartsWith("#"))
                    //    {

                    //        if (text.Foreground != Brushes.DarkGreen)
                    //        {
                    //            text.Foreground = Brushes.DarkGreen;
                    //            //i.Handled = true;
                    //        }
                    //    }
                    //    else
                    //    {
                    //        if (text.Foreground == Brushes.DarkGreen)
                    //        {
                    //            text.Foreground = Brushes.Black;
                    //            //i.Handled = true;
                    //        }
                    //        ////var tokens = text.Text.Split(FIXSeparator);

                    //        ////TextPointer foundRange = new TextPointer((paragraphNumber, text.Foreground);
                    //        ////rtb.Selection.Select(foundRange.Start, foundRange.End);

                    //        ////rtb.SelectionBrush = Brushes.LightGoldenrodYellow;
                    //        ////rtb.SelectionTextBrush = Brushes.IndianRed;
                    //        //var s = text.Text;
                    //        //for (int i = s.IndexOf(FIXSeparator); i > -1; i = s.IndexOf(FIXSeparator, i + 1))
                    //        //{
                    //        //    TextPointer selStart = paragraph.ContentStart.GetPositionAtOffset(i);
                    //        //    TextPointer selEnd = paragraph.ContentStart.GetPositionAtOffset(i + 1);
                    //        //    //rtb.Selection.Select(selStart, selEnd);
                    //        //    //rtb.SelectionBrush = Brushes.Yellow;
                    //        //    //rtb.SelectionTextBrush = Brushes.Red;

                    //        //    TextRange rangeSeparator = new TextRange(selStart, selEnd);
                    //        //    //rangeSeparator.Text = "This is a long string";
                    //        //    rangeSeparator.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);
                    //        //}
                    //   }
                    //}
                }
                busyUpdating = false;
            }
            catch (Exception ex)
            {
                busyUpdating = false;
            }


            //var dif = contentStart.GetOffsetToPosition(contentEnd);
            //var pc = contentStart.GetPointerContext(LogicalDirection.Forward);
            //pc = contentEnd.GetPointerContext(LogicalDirection.Backward);

            //var c = e.Changes;

            //var rtb_text = new TextRange(contentStart, contentEnd).Text;
            //var messageBoxText = $"contentStart: {contentStart}{Environment.NewLine}" +
            //    $"contentEnd: {contentEnd}{Environment.NewLine}" +
            //    $"{rtb_text}";


            //MessageBox.Show(messageBoxText, "Input::OnTextChanged", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);

            //// Calculate the starting position of the current line.  
            //int start = 0, end = 0;
            //for (start = input.Document.SelectionStart - 1; start > 0; start--)
            //{
            //    if (input.Text[start] == '\n') { start++; break; }
            //}
            //// Calculate the end position of the current line.  
            //for (end = input.SelectionStart; end < input.Text.Length; end++)
            //{
            //    if (input.Text[end] == '\n') break;
            //}
            //// Extract the current line that is being edited.  
            //String line = input.Text.Substring(start, end - start);
            //// Backup the users current selection point.  
            //int selectionStart = input.SelectionStart;
            //int selectionLength = input.SelectionLength;
            //// Split the line into tokens.  
            //Regex r = new Regex("([ \\t{}();])");
            //string[] tokens = r.Split(line);
            //int index = start;
            //foreach (string token in tokens)
            //{
            //    // Set the token's default color and font.  
            //    input.SelectionStart = index;
            //    input.SelectionLength = token.Length;
            //    input.SelectionColor = Color.Black;
            //    input.SelectionFont = new Font("Courier New", 10,
            //    FontStyle.Regular);
            //    // Check whether the token is a keyword.   
            //    String[] keywords = { "public", "void", "using", "static", "class" };
            //    for (int i = 0; i < keywords.Length; i++)
            //    {
            //        if (keywords[i] == token)
            //        {
            //            // Apply alternative color and font to highlight keyword.   
            //            input.SelectionColor = Color.Blue;
            //            input.SelectionFont = new Font("Courier New", 10,
            //            FontStyle.Bold);
            //            break;
            //        }

            //        index += token.Length;
            //    }
            //    // Restore the users current selection point.   
            //    input.SelectionStart = selectionStart;
            //    input.SelectionLength = selectionLength;
            //}

        }

        private void OnRTBPasting(object sender, DataObjectPastingEventArgs e)
        {
            e.Handled = true;
            FlowDocument mcFlowDoc = new FlowDocument();
            busyUpdating = true;
            if (e.DataObject.GetDataPresent(DataFormats.Text))
            {
                mcFlowDoc = rtbInput.Document ?? mcFlowDoc;
                string text = (string)e.DataObject.GetData(DataFormats.Text);
                var lines = text.Split('\n');
                foreach (var line in lines)
                {
                    var paragraph = LineToParagraph(line);
                    mcFlowDoc.Blocks.Add(paragraph);
                }
                // Do something with the text or inspect it.
                // If you want to modify the pasted content, set e.DataObject.
                e.DataObject = new DataObject(DataFormats.Text, string.Empty);
            }
            // If you want to prevent pasting, you can set e.Handled.
            Dispatcher.BeginInvoke(new Action(() =>
            {
                rtbInput.Document = mcFlowDoc;
            }), System.Windows.Threading.DispatcherPriority.Background);
            busyUpdating = false;
        }

        private Paragraph LineToParagraph(string line)
        {
            var paragraph = new Paragraph();

            if (string.IsNullOrEmpty(line))
            {
                return paragraph;
            }
            line = line.Trim();

            if (!line.Contains("8=FIX"))
            {
                paragraph.Inlines.Add(new Run(line) { Foreground = Brushes.Red });
                return paragraph;
            }

            if (line.StartsWith("#"))
            {
                paragraph.Inlines.Add(new Run(line) { Foreground = Brushes.Green });
                return paragraph;
            }

            var tokens = line.Split('\u0001');
            foreach (var token in tokens)
            {
                if (string.IsNullOrEmpty(token))
                    continue;
                paragraph.Inlines.Add(new Run(token) { Foreground = Brushes.Black, Background = Brushes.White });
                paragraph.Inlines.Add(new Run(FIXSeparator.ToString()) { Foreground = separatorBrush });
            }

            return paragraph;
        }

        private void LoadRichTextBox(string data)
        {
            FlowDocument mcFlowDoc = new FlowDocument();
            //Paragraph - line will be a paragraph
            //Run       - Each KeyPair will be a run, FIX separtor will be a run.
            data = "8=FIX.4.4\u00019=1255\u000135=8\u000134=215\u000149=BLP_PROD\u000152=20231031-14:27:43\u000156=VCON_ICOS_PROD\u0001115=DCSVC_11407_1\u0001128=ZERO\u0001142=Voice\u0001144=FI\u0001347=UTF-8\u00016=69.25\u000114=66000\u000115=USD\u000117=VCON:20231031:50302:1:12\u000122=1\u000130=XOFF\u000131=69.25\u000132=66000\u000137=VCON:20231031:50302:1\u000138=66000\u000139=2\u000148=3136A8HB9\u000154=1\u000155=[N/A]\u000160=20231031-14:26:22.000\u000164=20231103\u000175=20231031\u0001118=45716\u0001150=F\u0001151=0\u0001159=11\u0001167=MBS\u0001198=3739:20231031:50302:1\u0001223=0.03\u0001228=1\u0001236=0.067267\u0001381=45705\u0001423=1\u0001460=10\u0001470=US\u0001541=20420925\u0001669=69.25\u0001854=0\u00011430=V\u00011913=0\u00011950=1\u00015537=66000\u00017014=21\u000122448=1\u0001453=7\u0001448=HATI\u0001447=D\u0001452=1\u0001802=2\u0001523=236630\u0001803=4014\u0001523=N\u0001803=4069\u0001448=MCKINNEY1:31192908\u0001447=D\u0001452=11\u0001802=4\u0001523=14\u0001803=4\u0001523=MICHAEL MCKINNEY\u0001803=9\u0001523=BOCA RATON\u0001803=34\u0001523=US\u0001803=38\u0001448=BBRANAGAN1:11662592\u0001447=D\u0001452=12\u0001802=3\u0001523=BILL BRANAGAN\u0001803=9\u0001523=JERSEY CITY\u0001803=34\u0001523=US\u0001803=38\u0001448=INTERCOASTAL CAPITAL MARKETS INC\u0001447=D\u0001452=13\u0001802=2\u0001523=873396\u0001803=4014\u0001523=N\u0001803=4069\u0001448=BBRANAGAN1:11662592\u0001447=D\u0001452=36\u0001802=3\u0001523=BILL BRANAGAN\u0001803=9\u0001523=JERSEY CITY\u0001803=34\u0001523=US\u0001803=38\u0001448=XOFF\u0001447=G\u0001452=73\u0001448=SXT\u0001447=D\u0001452=16\u0001454=4\u0001455=US3136A8HB97\u0001456=4\u0001455=3136A8HB9\u0001456=1\u0001455=CM4G7562\u0001456=A\u0001455=FNR\u0001456=8\u0001768=3\u0001769=20231031-14:26:22.000\u0001770=1\u0001769=20231031-14:26:43.896\u0001770=2\u0001769=20231031-14:27:43.584\u0001770=113\u00012529=1\u00012530=101\u00012531=6.7267\u000110=089\u0001";
            var tokens = data.Split('\u0001');
            Paragraph para = new Paragraph();
            var sep = new Run(FIXSeparator.ToString()) { Foreground = Brushes.Red };
            foreach (var token in tokens)
            {
                para.Inlines.Add(new Run(token) { Background = Brushes.White });
                para.Inlines.Add(new Run(FIXSeparator.ToString()) { Foreground = separatorBrush });
            }
            mcFlowDoc.Blocks.Add(para);
            rtbInput.Document = mcFlowDoc;
        }

        private void OnRTBPreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tr = GetWordByDelimiters();

            // Color the selected text 
            var bg = tr.GetPropertyValue(TextElement.BackgroundProperty) as Brush;
            if (bg == Brushes.Yellow)
                tr.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.White);
            else
                tr.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Yellow);
            rtbInput.Focus();

            e.Handled = true;
        }

        public TextRange GetWordByDelimiters()
        {
            TextPointer current = rtbInput.CaretPosition;

            // \s matches any whitespace character (equivalent to [\r\n\t\f\v ])
            string pattern = @"[^\s]+"; // Delimiters 

            // The run content before the current caret position
            string backward = current.GetTextInRun(LogicalDirection.Backward);

            // Scan text before caret
            Match match = Regex.Match(backward, pattern, RegexOptions.RightToLeft);

            TextPointer start = current;
            if (match.Success && match.Index + match.Value.Length == backward.Length)
            {
                start = start.GetPositionAtOffset(-backward.Length + match.Index);
            }

            // The run content after the current caret position
            string forward = current.GetTextInRun(LogicalDirection.Forward);

            // Scan text after caret
            match = Regex.Match(forward, pattern);

            TextPointer end = current;
            if (match.Success && match.Index == 0)
            {
                end = end.GetPositionAtOffset(match.Value.Length, LogicalDirection.Forward);
            }
            return new TextRange(start, end);
        }

    }
}
