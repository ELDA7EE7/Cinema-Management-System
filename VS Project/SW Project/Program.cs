﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Register register = new Register();
            register.Show();
            //UserSpendingCrystalReportForm scheduleCrystalReportForm = new UserSpendingCrystalReportForm();
            //scheduleCrystalReportForm.Show();
            Application.Run();

        }
    }
}
