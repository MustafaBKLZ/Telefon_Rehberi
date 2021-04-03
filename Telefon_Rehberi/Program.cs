using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cls.SQLConnectionClass.Baglanti();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KullaniciGiris());
        }
    }
}
