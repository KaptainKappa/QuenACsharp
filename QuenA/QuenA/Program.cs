using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuenA.ui;
using QuenA.Data;
using RedWards.Patterns.Observer;
using QuenA.Data.Control;
using System.IO;

namespace QuenA
{
    static class Program
    {


        private static MainWindow mainWindow;
        public static MainWindow MainWindow { get { return mainWindow; } }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG

            Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                mainWindow = new MainWindow();
                Application.Run(mainWindow);
           
#else
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                mainWindow = new MainWindow();
                Application.Run(mainWindow);
            }
            catch (Exception ex)
            {
                //Write ex.Message to a file
                using (StreamWriter outfile = new StreamWriter(@".\error" + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + ".txt"))
                {
                    outfile.Write(ex.Message.ToString());
                }
            }
#endif

        }
      
    }
}


