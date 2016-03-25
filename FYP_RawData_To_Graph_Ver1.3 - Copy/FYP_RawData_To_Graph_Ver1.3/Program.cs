using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FYP_RawData_To_Graph_Ver1._3
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
        }
    }
}
