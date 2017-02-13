using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program Name: Sharp Auto Form     Date Last Modified: February 12th
//Name: Caitlin Foster              student#: 200311158
//This program will allow a user to calcuylate a customized a car order


namespace Assignment2
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
            Application.Run(new SharpAutoForm());
        }
    }
}
