using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classEstIndem
    {
        private int leAn;
        private double lesNbKmAn;
        private classVehiculeSociete leVehiculeSociete;
        private classIndemKm laIndem;

        /// <summary>
        /// Constructeur de la classe classEstIndem si nouvelle indemnisation kilometrique
        /// </summary>
        /// <param name="unAn">L'année de l'indemnisation</param>
        public classEstIndem(int unAn)
        {
            this.leAn = unAn;
        }

        /// <summary>
        /// Constructeur de la classe classEstIndem si indemnisation kilometrique prédefinie
        /// </summary>
        /// <param name="unAn">L'année de l'indemnisation</param>
        /// <param name="desNbKmAn">le nb de km par an du vehicule</param>
        /// <param name="unVehiculeSociete">L'objet vehicule société</param>
        /// <param name="uneIndem">L'objet classIndemKm qui concerne le vehicule</param>
        public classEstIndem(int unAn, double desNbKmAn, classVehiculeSociete unVehiculeSociete, classIndemKm uneIndem)
        {
            this.leAn = unAn;
            this.lesNbKmAn = desNbKmAn;
            this.leVehiculeSociete = unVehiculeSociete;
            this.laIndem = uneIndem;
        }

        /// <summary>
        /// Fonction qui retourne l'année concernant l'objet courant
        /// </summary>
        /// <returns>L'année de l'indemnisation</returns>
        public int getAnIndem()
        {
            return this.leAn;
        }

        /// <summary>
        /// Fonction qui retourne le nb de km par an du vehicule
        /// </summary>
        /// <returns></returns>
        public double getLeNbKmAn()
        {
            return this.lesNbKmAn;
        }

        /// <summary>
        /// Fonction qui retourne l'objet classVehiculeSociete de l'objet courant
        /// </summary>
        /// <returns></returns>
        public classVehiculeSociete getLeVehiculeSociété()
        {
            return this.leVehiculeSociete;
        }

        /// <summary>
        /// Fonction qui retourne la indemKm de l'objet courant
        /// </summary>
        /// <returns></returns>
        public classIndemKm getIndemKm()
        {
            return this.laIndem;
        }

    }
}
