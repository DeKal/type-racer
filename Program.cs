﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{
    static class Program
    {
        private static Game MainGame;
        public static Game GetMainGame(){
            return MainGame;
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainGame=new Game();
            Application.Run(MainGame);
        }
    }
}
