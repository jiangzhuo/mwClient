﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mwClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //Application.Run(new Form1());
            //Application.Run(new frmMain());
            Application.Run(new GateLogin());
            //Application.Run(new Form2());

        }
    }
}
