using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResolutionPolynomes
{
    /// <summary>
    /// Classe représentant une fenêtre graphique.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Tests fonctions
            float a = 1.0f, b = 2.0f, c = 3.0f;

            string res = Outils.SecondDegre(a, b, c);

            txtb_res.Text = res;
        }
    }
}
