using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name : Harmanpreet Singh
 * Date : August 3,2017
 * Student ID : 300931446
 * Description : Calculator Demo Project
 * version 0.1 : Created the Project
 * */
namespace COMP123_S2017_12B2
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
            Application.Run(new CalculatorForm());
        }
    }
}
