using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis
{
    public class classEquipe
    {
        private String leNomEquipe;
        private List<classElement> lesElements;
        private List<classElementPersonnalisable> lesElementsPersonnalisables;
        private List<classVehiculeSociete> lesVehiculesSociete;
        
        /// <summary>
        /// Constructeur en cas de nouvelle équipe personnalisé
        /// </summary>
        /// <param name="unNomEquipe"> Le nom de l'équipe </param>
        public classEquipe(String unNomEquipe)
        {
            leNomEquipe = unNomEquipe;
            lesElements = new List<classElement>();
            lesElementsPersonnalisables = new List<classElementPersonnalisable>();
            lesVehiculesSociete = new List<classVehiculeSociete>();
        }

        /// <summary>
        /// Constructeur en cas d'equipe issue d'un modèle avec des éléments deja existants
        /// </summary>
        /// <param name="unNomEquipe">Le nom de l'équipe </param>
        /// <param name="desElements">La liste des éléments prédéfinis</param>
        public classEquipe(String unNomEquipe, List<classElement> desElements)
        {
            leNomEquipe = unNomEquipe;
            lesElements = desElements;
        }

        /// <summary>
        /// Fonction qui returne le nom de l'équipe
        /// </summary>
        /// <returns>Le nom de l'équipe en cours</returns>
        public String getNomEquipe()
        {
            return this.leNomEquipe;
        }

        /// <summary>
        /// Fonction retoune la collection des éléments en cours
        /// </summary>
        /// <returns>La collection des éléments en cours</returns>
        public List<classElement> getLesElements()
        {
            return this.lesElements;
        }

        public List<classElementPersonnalisable> getLesElementsPersonnalisables()
        {
            return this.lesElementsPersonnalisables;
        }

        public List<classVehiculeSociete> getLesVehiculesSociete()
        {
            return this.lesVehiculesSociete;
        }

        public void ajouterElement(classElement unElement)
        {
            lesElements.Add(unElement);
        }

        public void ajouterElementPersonnalisable(classElementPersonnalisable unElementPerso)
        {
            lesElementsPersonnalisables.Add(unElementPerso);
        }

        public void ajouterUnVehiculeSociete(classVehiculeSociete unVehiculeSociete)
        {
            lesVehiculesSociete.Add(unVehiculeSociete);
        }
    }
}
