using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Second_Sens___Devis;

namespace Second_Sens___Devis
{
    /// <summary>
    /// Classe technique qui effectue les requêtes à la base de données.
    /// </summary>
    public class requetesMySQL
    {
        static private MySqlConnection laConnexion = lienBdD.getConnection();
        private MySqlCommand laCommande = new MySqlCommand();
        /// <summary>
        /// Constructeur de la classe commandeMySQL
        /// </summary>
        public requetesMySQL()
        {
            laCommande.Connection = laConnexion;
        }

        /// <summary>
        /// Traite une requête MySQL de type query qui returne un liste de objets String
        /// </summary>
        /// <param name="uneCommande">La requête MySQL</param>
        /// <returns>La liste correspodant résultat de la requête MySQL</returns>
        public List<String> queryString(String uneRequete)
        {
            laCommande.CommandText = uneRequete;
            List<String> listResultats = new List<String>();
            MySqlDataReader lesResultats = laCommande.ExecuteReader();
            while (lesResultats.Read())
            {
                int nbRows = lesResultats.FieldCount;
                for (int i = 0; i <= nbRows; i++)
                {
                    listResultats.Add(lesResultats.GetValue(i).ToString());
                }
            }
            return listResultats;
        }

        /// <summary>
        /// Traite une requête MySQL de type query qui returne un liste de type Int
        /// </summary>
        /// <param name="uneCommande">La requête MySQL</param>
        /// <returns>La liste correspodant résultat de la requête MySQL</returns>
        public List<int> queryInt(String uneRequete)
        {
            laCommande.CommandText = uneRequete;
            List<int> listResultats = new List<int>();
            MySqlDataReader lesResultats = laCommande.ExecuteReader();
            while (lesResultats.Read())
            {
                int nbRows = lesResultats.FieldCount;
                for (int i = 0; i <= nbRows; i++)
                {
                    listResultats.Add(Convert.ToInt32(lesResultats.GetValue(i)));
                }
            }
            return listResultats;
        }

        /// <summary>
        /// Traite une requête MySQL de type query qui returne un liste de type double
        /// </summary>
        /// <param name="uneCommande">La requête MySQL</param>
        /// <returns>La liste correspodant résultat de la requête MySQL</returns>
        public List<double> queryDouble(String uneRequete)
        {
            laCommande.CommandText = uneRequete;
            List<double> listResultats = new List<double>();
            MySqlDataReader lesResultats = laCommande.ExecuteReader();
            while (lesResultats.Read())
            {
                int nbRows = lesResultats.FieldCount;
                for(int i=0; i<=nbRows; i++)
                {
                    try
                    {
                        listResultats.Add(Convert.ToDouble(lesResultats.GetValue(i)));
                    }
                    catch(Exception erreur)
                    {
                        /* ignoré blblablabla */
                    }

                }
            }
            lesResultats.Close();
            return listResultats;
        }

        /// <summary>
        /// Traite une requête MySQL qui intéragit avec la BdD
        /// </summary>
        /// <param name="uneRequete">La requête MySQL</param>
        /// <returns>Retourne true si l'intéraction avec la base a lieu avec succès sinon retourne false</returns>
        public bool modifBdD(String uneRequete)
        {
            bool confirmation = false;
            int rowsAffected;
            laCommande.CommandText = uneRequete;
            try
            {
                rowsAffected = laCommande.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    confirmation = true;
                }
                else
                {
                    confirmation = false;
                }
            }
            catch(Exception e)
            {
                confirmation = false;
            }
            return confirmation;
        }
    }
}
