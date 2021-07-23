using System;
using System.Windows.Forms;

namespace ComputerComposerNsp
{
    static class Program
    {
        //creating new variable for checking if logging was successful
        public static bool logged;
        public static string user;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormLogin());

            //creating new form for better management
            FormMain formMain = new FormMain();

            //if logging is successful
            if (logged)
            {
                //series of operations for show new window in front of rest windows
                formMain.WindowState = FormWindowState.Minimized;
                formMain.Show();
                formMain.WindowState = FormWindowState.Normal;
                //running FormMain
                Application.Run(formMain);
            }
        }
    }
}
