using System;
using System.Windows.Forms;
using SBP_Projekat.Forme;

namespace SBP_Projekat
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
            Application.Run(new GlavnaForma());
        }
    }
}
