using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAL;

namespace ProspectApp
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IProspectRepository prospectRepo = new StubProspectRepository();

            Application.Run(new MainForm(prospectRepo));
        }
    }
}
