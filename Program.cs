using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

namespace ablauncher {
    static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AtomicBomberman game = AtomicBomberman.construct();
            if (game == null) {
                MessageBox.Show("Please place the Launcher in the same directory as the \"BM95.EXE\" game file.", "Atomic Bomberman not found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Application.Run(new MainForm(game));
        }
    }
}