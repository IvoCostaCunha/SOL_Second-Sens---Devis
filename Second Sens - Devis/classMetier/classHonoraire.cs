using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classHonoraire
    {
        private String leNomHonoraire;
        private classTarif leTarif;

        /// <summary>
        /// Constructeur de la classe classHonoraire en cas de nouvel honoraire
        /// </summary>
        /// <param name="unNomTarif">Le nom du tarif</param>
        public classHonoraire(String unNomTarif)
        {
            this.leNomHonoraire = unNomTarif;
        } 

        /// <summary>
        /// Constructeur de la classe classHonoraire en cas d'honoraire prédéfini
        /// </summary>
        /// <param name="unNomHonoraire">Le nom de l'honoraire</param>
        /// <param name="unTarif">Le tarif de l'honoraire</param>
        public classHonoraire(String unNomHonoraire, classTarif unTarif)
        {
            this.leNomHonoraire = unNomHonoraire;
            this.leTarif = unTarif;
        }

        /// <summary>
        /// Méthode qui set le tarif a un honoraire
        /// </summary>
        /// <param name="unTarif"></param>
        public void setTarif(classTarif unTarif)
        {
            this.leTarif = unTarif;
        }
    }
}
