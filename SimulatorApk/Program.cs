using CsvHelper;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace SimulatorApk
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());


        }
    }
}