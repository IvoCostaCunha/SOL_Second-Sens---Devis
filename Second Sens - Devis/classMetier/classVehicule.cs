using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classVehicule : classElement
    {
        /// <summary>
        /// Constructeur de la classe fille classVehicule de classElement en cas de nouveau vehicule
        /// </summary>
        /// <param name="unNomVehicule"></param>
        public classVehicule(String unNomVehicule) : base(unNomVehicule)
        {
            this.leNomElement = unNomVehicule;
        }

        /// <summary>
        /// Constructeur de la classe fille classvehicule de classElement en cas de vehicule prédéfini
        /// </summary>
        /// <param name="unNomVehicule"></param>
        /// <param name="unTarif"></param>
        public classVehicule(String unNomVehicule, classTarif unTarif) : base(unNomVehicule, unTarif)
        {
            this.leNomElement = unNomVehicule;
            this.leTarif = unTarif;
        }
    }
}
