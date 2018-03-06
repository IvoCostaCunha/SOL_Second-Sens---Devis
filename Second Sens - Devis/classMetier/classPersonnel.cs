using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classPersonnel : classElement
    {
        /// <summary>
        /// Constructeur de la classe fille classPersonnel de classElement si prédéfinie
        /// </summary>
        /// <param name="nomPersonnel"></param>
        /// <param name="unTarif"></param>
        public classPersonnel(String nomPersonnel, classTarif unTarif) : base(nomPersonnel, unTarif)
        {
            this.leNomElement = nomPersonnel;
            this.leTarif = unTarif;
        }

        /// <summary>
        /// Constructeur de la classe fille classPersonnel de classElement si le tarif est inconnu
        /// </summary>
        /// <param name="nomPersonnel"></param>
        public classPersonnel(String nomPersonnel) : base(nomPersonnel)
        {
            this.leNomElement = nomPersonnel;
        }
    }
}
