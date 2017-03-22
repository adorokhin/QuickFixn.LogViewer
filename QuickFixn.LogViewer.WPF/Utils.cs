using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixn.LogViewer.WPF
{
    public static class MyExtentions
    {

        public static string FeedFormatException(this Exception ex, string sNote)
        {
            string sResult = "<EE> " + DateTime.Now.ToString("yyyyMMdd hh:mm:ss") + " " + sNote + System.Environment.NewLine;
            sResult += "------- EXCEPTION ------------------------------" + System.Environment.NewLine;
            sResult += ex.Message + System.Environment.NewLine;
            sResult += "------- SOURCE ------------------------------" + System.Environment.NewLine;
            sResult += ex.Source + System.Environment.NewLine;
            sResult += "------- STACK TRACE ----------------------------" + System.Environment.NewLine;
            sResult += ex.StackTrace + System.Environment.NewLine;
            return sResult;
        }

        public static string FeedFormatExceptionHTML(this Exception ex, string sNote)
        {
            string sResult = "<EE> " + DateTime.Now.ToString("yyyyMMdd hh:mm:ss") + " " + sNote + "<BR>";
            sResult += "------- EXCEPTION ------------------------------<BR>";
            sResult += ex.Message + "<BR>";
            sResult += "------- SOURCE ------------------------------<BR>";
            sResult += ex.Source + "<BR>";
            sResult += "------- STACK TRACE ----------------------------<BR>";
            sResult += ex.StackTrace + "<BR>";
            return sResult;
        }

    }
}
