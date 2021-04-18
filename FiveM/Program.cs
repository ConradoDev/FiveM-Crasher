﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveM {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Task.Run(() => {
                Application.Run(new Menu());
            }).GetAwaiter().GetResult();            
        }
    }
}
