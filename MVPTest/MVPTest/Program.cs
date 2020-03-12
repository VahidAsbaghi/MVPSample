﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPTest.Presentation;

namespace MVPTest
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

            var appController = new ApplicationController();
            var view = new ViewMain();
            var presenter = new ViewMainPresenter(view, appController);

            Application.Run(view);
        }
    }
}