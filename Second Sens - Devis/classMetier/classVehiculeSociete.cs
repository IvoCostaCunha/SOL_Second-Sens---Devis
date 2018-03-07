using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classVehiculeSociete : classElement
    {
        private classIndemKm laIndemKm;

        /// <summary>
        /// Constructeur de la classe fille classVehiculeSociete de classVehicule en cas de vehicule société nouveau
        /// </summary>
        /// <param name="unNomVehiculeSociete"></param>
        public classVehiculeSociete(String unNomVehiculeSociete) : base(unNomVehiculeSociete)
        {
            leNomElement = unNomVehiculeSociete;
        }

        /// <summary>
        /// Constructeur de la classe fille classVehiculeSociete de classVehicule en cas de vehicule société prédefini 
        /// </summary>
        /// <param name="unNomVehiculeSociété"></param>
        /// <param name="unTarif"></param>
        /// <param name="uneIndemKm"></param>
        public classVehiculeSociete(String unNomVehiculeSociété, classTarif unTarif, classIndemKm uneIndemKm) : base (unNomVehiculeSociété, unTarif)
        {
            this.leNomElement = unNomVehiculeSociété;
            this.leTarif = unTarif;
            this.laIndemKm = uneIndemKm;
        }

        /// <summary>
        /// Fonction sui retourne la IndemKm du vehicule société
        /// </summary>
        /// <param name="uneIndemKm"></param>
        /// <returns></returns>
        public classIndemKm getIndemKm()
        {
            return this.laIndemKm;
        }

        /// <summary>
        /// Methode qui set l'indemKm a un vehicule société
        /// </summary>
        /// <param name="uneIndemKm"></param>
        public void setIndemKm(classIndemKm uneIndemKm)
        {
            this.laIndemKm = uneIndemKm;
        }
    }
}
