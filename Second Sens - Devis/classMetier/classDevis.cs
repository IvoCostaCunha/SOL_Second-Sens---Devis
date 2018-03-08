using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    public class classDevis
    {
        private String leNomDevis;
        private DateTime laDateCreationDevis;
        private List<classEquipe> lesEquipes = new List<classEquipe>();
        private int leNombreJours;

        /// <summary>
        /// Constructeur de la classe classDevis
        /// </summary>
        /// <param name="unNomDevis">Le nom du devis</param>
        /// <param name="uneDateCreation">La date de création du devis</param>
        public classDevis(String unNomDevis, DateTime uneDateCreation, int unNombreJours)
        {
            leNombreJours = unNombreJours;
            leNomDevis = unNomDevis;
            laDateCreationDevis = uneDateCreation;
        }

        /// <summary>
        /// Méthode qui retourne le nom du devis
        /// </summary>
        /// <returns>Le nom du devis</returns>
        public String getNomDevis()
        {
            return this.leNomDevis;
        }

        /// <summary>
        /// Fonction qui retourne la date de création du devis 
        /// </summary>
        /// <returns></returns>
        public DateTime getDateCreationDevis()
        {
            return this.laDateCreationDevis;
        }

        public int getNbJoursOpe()
        {
            return this.leNombreJours;
        }
    }
}
