using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classHotesse : classPersonnel
    {
        private List<classPersonnalisation> lesPersonnalisations;

        /// <summary>
        /// Constructeur de la classe classPersonnalisation si prédéfinie
        /// </summary>
        /// <param name="unNomHotesse"></param>
        /// <param name="unTarif"></param>
        /// <param name="unePersonnalisation">Collection de classPersonnalisation</param>
        public classHotesse(String unNomHotesse, classTarif unTarif, List<classPersonnalisation> unePersonnalisation) : base(unNomHotesse, unTarif)
        {
            this.leNomElement = unNomHotesse;
            this.leTarif = unTarif;
            this.lesPersonnalisations = unePersonnalisation;
        }

        /// <summary>
        /// Constructeur de la classe classHotesse en cas de personnalisation pas encore définie
        /// </summary>
        /// <param name="unNomHotesse"></param>
        /// <param name="unTarif"></param>
        public classHotesse(String unNomHotesse, classTarif unTarif) : base (unNomHotesse, unTarif)
        {
            this.leNomElement = unNomHotesse;
            this.leTarif = unTarif;
        }

        /// <summary>
        /// Constructeur de la classe classHotessse en cas de tarif et personnalisation non connue encore
        /// </summary>
        /// <param name="unNomHotesse"></param>
        public classHotesse(String unNomHotesse) : base(unNomHotesse)
        {
            this.leNomElement = unNomHotesse;
        }

        /// <summary>
        /// Fonction qui retourne la collection des personnalisations de l'objet courrant
        /// </summary>
        /// <returns></returns>
        public List<classPersonnalisation> getLesPersonnalisations()
        {
            return this.lesPersonnalisations;
        }

        /// <summary>
        /// Méthode qui instancie la collection lesPersonnalisations avec son paramètre
        /// </summary>
        /// <param name="desPersonnalisations"></param>
        public void setLesPersonnalisations(List<classPersonnalisation> desPersonnalisations)
        {
            lesPersonnalisations = desPersonnalisations;
        }

        /// <summary>
        /// Méthode qui ajoute une personnalisation à la collection lesPersonnalisations
        /// </summary>
        /// <param name="unePersonnalisation"></param>
        public void addPersonnalisation(classPersonnalisation unePersonnalisation)
        {
            this.lesPersonnalisations.Add(unePersonnalisation);
        }
    }
}
