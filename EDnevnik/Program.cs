using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik
{
    static class Program
    {
        private static int uloga;
        private static string ime;
        private static string prezime;

        public static string Prezime { get => prezime; set => prezime = value; }
        public static string Ime { get => ime; set => ime = value; }
        public static int Uloga { get => uloga; set => uloga = value; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
