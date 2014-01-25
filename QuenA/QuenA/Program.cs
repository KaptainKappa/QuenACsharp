using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuenA.ui;
using QuenA.Data;
using RedWards.Patterns.Observer;
using QuenA.Data.Control;

namespace QuenA
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
            Application.Run(MainWindow.Instance);
        }
      
    }
}


