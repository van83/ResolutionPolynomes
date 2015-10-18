using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ResolutionPolynomes
{
    /// <summary>
    /// Classe par défaut.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Init UI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
