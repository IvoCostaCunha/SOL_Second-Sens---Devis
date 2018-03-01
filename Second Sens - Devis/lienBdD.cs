using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Second_Sens___Devis
{
    /// <summary>
    /// Classe qui créer une connexion a la base de données ou qui déconnecte de celle-ci.
    /// </summary>
    public static class lienBdD
    {
        static private String login = "root";
        static private String mdp = "";
        static private String port = "3306";
        static private String serverBdD = "localhost";
        static private String nomBdD = "secondsens_devis";
        static private String chaineConnection = "Server =" + serverBdD + ";Port=" + port + ";Database="
            + nomBdD + ";Uid=" + login + ";Pwd=" + mdp + ";";

        static private MySqlConnection connectionMySql = new MySqlConnection(chaineConnection);
        
        /// <summary>
        /// Methode de connexion a la BdD 
        /// </summary>
        static public void startConnection() {
            connectionMySql.Open();
        }

        /// <summary>
        /// Methode de déconnexion à la connection a la BdD
        /// </summary>
        static public void stopConnection()
        {
            connectionMySql.Close();
        }

        /// <summary>
        /// Retourne la connexion en cours si ouverte
        /// </summary>
        /// <returns>Un objet MySqlCOnnection qui est la connexion en cours</returns>
        static public MySqlConnection getConnection()
        {
                return connectionMySql;
        }
    }
}
