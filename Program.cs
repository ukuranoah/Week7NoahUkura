using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6NoahUkura
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*PersonV2 temp = new PersonV2();
            if (!temp.Feedback.Contains("Error:"))
            {
                string strFeedback = temp.AddRecord();
                //lblFeedback.Text = strFeedback;
            }
            else
            {
                //lblFeedback.Text = temp.Feedback;
            }*/
            //BasicTools.Pause();
        }
    }
}
