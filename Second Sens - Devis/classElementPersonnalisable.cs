using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis
{ 
    public class classElementPersonnalisable : classElement
    {
        private List<classPersonnalisation> lesPersonnalisations;

        /// <summary>
        /// Constructeur de la classe classElementPersonnalisable si prédéfinie
        /// </summary>
        /// <param name="unNomElement"></param>
        /// <param name="unTarif"></param>
        /// <param name="desPersonnalisations"></param>
        public classElementPersonnalisable(String unNomElement, classTarif unTarif,int unNbElement, List<classPersonnalisation> desPersonnalisations) : base(unNomElement, unTarif, unNbElement)
        {
            this.leNomElement = unNomElement;
            this.leTarif = unTarif;
            this.lesPersonnalisations = desPersonnalisations;
        }

        /// <summary>
        /// Constructeur de la classe classElementPersonnalisable si nouvel element personnalisable
        /// </summary>
        /// <param name="unNomElement"></param>
        public classElementPersonnalisable(String unNomElement) : base(unNomElement)
        {
            this.leNomElement = unNomElement;
        }

        /// <summary>
        /// Méthode qui set la collection de personnalisations a l'objet courant
        /// </summary>
        /// <param name="desPersonnalisations"></param>
        public void setLesPersonnalisations(List<classPersonnalisation> desPersonnalisations)
        {
            this.lesPersonnalisations = desPersonnalisations;
        }

        /// <summary>
        /// Fonction qui retourne la collection de personnalisations de l'objet courant
        /// </summary>
        /// <returns></returns>
        public List<classPersonnalisation> getLesPersonnalisation()
        {
            return this.lesPersonnalisations;
        }

        /// <summary>
        /// Méthode qui rajoute une personnalisation à la collection des personnalisations
        /// </summary>
        /// <param name="unePersonnalisation"></param>
        public void addPersonnalisation(classPersonnalisation unePersonnalisation)
        {
            this.lesPersonnalisations.Add(unePersonnalisation);
        }
    }
}
