using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Second_Sens___Devis.classMetier
{
    /// <summary>
    /// Classe qui effectue les accès a la table INDEMKM de la base SECONDSENS_DEVIS
    /// </summary>
    public static class indemKm
    {
        private static MySqlConnection laConnexion = lienBdD.getConnection();
        
        /// <summary>
        /// Récupere les coefs d'indemnité selon 
        /// </summary>
        /// <param name="unNbKmAn"></param>
        /// <param name="nbCV"></param>
        /// <returns>La contenant les coeficients de l'indem Kilometrique</returns>
        public static List<double> getCoeficients(String unNbKmAn, int nbCV)
        {
            List<double> lesCoeficients = new List<double>();
            requetesMySQL laRequete = new requetesMySQL();
            lesCoeficients = laRequete.queryDouble("select coef,coef2 from indemKm where nbKmAn =" 
                + unNbKmAn + " and nbCV =" + nbCV.ToString());
           
            return lesCoeficients;
        }
    }
}
