using System;
namespace ResolutionPolynomes
{
    /// <summary>
    /// Classe regroupant les fonctions de résolution de polynômes.
    /// </summary>
    class Outils
    {
        /// <summary>
        /// Résolution d'un polynôme du premier degré.
        /// </summary>
        /// <param name="a">Facteur de degré 1.</param>
        /// <param name="b">Constante.</param>
        /// <returns>La racine du polynôme.</returns>
        public static string PremierDegre(float a, float b)
        {
            return a == 0.0 ? b.ToString() : (-b/a).ToString();
        }
        
        /// <summary>
        /// Résolution d'un polynôme du second degré.
        /// </summary>
        /// <param name="a">Facteur de degré 2.</param>
        /// <param name="b">Facteur de degré 1.</param>
        /// <param name="c">Constante.</param>
        /// <returns>Les racines sous forme de String.</returns>
        public static string SecondDegre(float a, float b, float c)
        {
            // Premier degré (a = 0)
            if (a == 0.0)
            {
                return PremierDegre(b, c);
            }

            float delta = b*b - 4*a*c;

            // Une racine réelle simple
            if (delta == 0.0)
            {
                return (-b / (2*a)).ToString();
            }

            // Une racine réelle double
            if (delta > 0.0)
            {
                return (-b + Math.Sqrt(delta)) / (2.0*a)
                    + " ; " +
                    (-b - Math.Sqrt(delta)) / (2.0*a);
            }

            // Deux racines complexes conjuguées
            return -b / (2.0*a) + " + i" + (Math.Sqrt(-delta) / (2.0*a))
                    + " ; " +
                    -b / (2.0*a) + " - i" + (Math.Sqrt(-delta) / (2.0*a));
        }
    }
}