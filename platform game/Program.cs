﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace platform_game
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

            Application.Run(new platform_game.StartingPage());
            //Application.Run(new platform_game.Form2());
            //Application.Run(new platform_game.Form3());
            //Application.Run(new Platform_Game.Form1());
            

        }
    }
}
