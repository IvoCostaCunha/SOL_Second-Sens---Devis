using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classStreetMarketing : classElement
    {
        private List<classPersonnalisation> lesPersonnalisations;

        /// <summary>
        /// Constructeur de la classe classStreetMarketing si prédefinie avec toutes ses propriètés
        /// </summary>
        /// <param name="unNomStreetMarketing"></param>
        /// <param name="unTarif"></param>
        /// <param name="desPersonnalisations"></param>
        public classStreetMarketing(String unNomStreetMarketing, classTarif unTarif, List<classPersonnalisation> desPersonnalisations) : base(unNomStreetMarketing, unTarif)
        {
            this.leNomElement = unNomStreetMarketing;
            this.leTarif = unTarif;
            this.lesPersonnalisations = desPersonnalisations;
        }

        /// <summary>
        /// Constructeur de la classe classStreetMarketing si personnalisations pas encore définies
        /// </summary>
        /// <param name="unNomStreetMarketing"></param>
        /// <param name="unTarif"></param>
        public classStreetMarketing(String unNomStreetMarketing, classTarif unTarif) : base(unNomStreetMarketing, unTarif)
        {
            this.leNomElement = unNomStreetMarketing;
            this.leTarif = unTarif;
        }

        /// <summary>
        /// Constructeur de la classe classStreetMarketing si ni le tarif ni les personnalisations sont définies
        /// </summary>
        /// <param name="unNomStreetMarketing"></param>
        public classStreetMarketing(String unNomStreetMarketing) : base(unNomStreetMarketing)
        {
            this.leNomElement = unNomStreetMarketing;
        }

        /// <summary>
        /// Fonction qui retourne la collection des personnalisations de l'objet courant
        /// </summary>
        /// <returns></returns>
        public List<classPersonnalisation> getLesPersonnalisations()
        {
            return this.lesPersonnalisations;
        }

        /// <summary>
        /// Méthode qui set la collection des personnalisations
        /// </summary>
        /// <param name="desPersonnalisations"></param>
        public void setLesPersonnalisations(List<classPersonnalisation> desPersonnalisations)
        {
            this.lesPersonnalisations = desPersonnalisations;
        }

        /// <summary>
        /// Méthode qui ajoute une personnalisation a la collection des personnalisations
        /// </summary>
        /// <param name="unePersonnalisation"></param>
        public void addPersonnalisation(classPersonnalisation unePersonnalisation)
        {
            lesPersonnalisations.Add(unePersonnalisation);
        }
    }
}
