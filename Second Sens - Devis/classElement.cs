﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis
{
    public class classElement
    {
        protected String leNomElement;
        protected classTarif leTarif;
        protected int leNbElement;
        protected int leNbJours;
        protected int leNbHeuresParJour;

        /// <summary>
        /// Constructeur en cas de nouvel élément
        /// </summary>
        /// <param name="unNomElement">Le nom de l'élément</param>
        public classElement(String unNomElement)
        {
            leNomElement = unNomElement;
        }

        /// <summary>
        /// Constructeur en cas de élément prédifini
        /// </summary>
        /// <param name="unNomElement"></param>
        /// <param name="unTarif"></param>
        public classElement(String unNomElement, classTarif unTarif, int unNbElement)
        {
            leNbElement = unNbElement;
            leNomElement = unNomElement;
            leTarif = unTarif;
        }

        /// <summary>
        /// Constructeur complet avec les durées
        /// </summary>
        /// <param name="unNomElement"></param>
        /// <param name="unTarif"></param>
        /// <param name="unNbElement"></param>
        /// <param name="unNbJours"></param>
        /// <param name="unNbHeuresParJour"></param>
        public classElement(String unNomElement, classTarif unTarif, int unNbElement, int unNbJours, int unNbHeuresParJour)
        {
            leNbElement = unNbElement;
            leNomElement = unNomElement;
            leTarif = unTarif;
            leNbJours = unNbJours;
            leNbHeuresParJour = unNbHeuresParJour;
        }

        /// <summary>
        /// Fonction qui retourne le nom de l'élément
        /// </summary>
        /// <returns></returns>
        protected String getNomElement()
        {
            return this.leNomElement;
        }

        /// <summary>
        /// Fonction qui retourne le tarif associé a l'élément
        /// </summary>
        /// <returns></returns>
        public classTarif getTarif()
        {
            return this.leTarif;
        }

        /// <summary>
        /// Méthode qui attribue a un élément un tarif de classe classTarif
        /// </summary>
        /// <param name="unTarif">Le tarif de classTarif</param>
        public void setTarif(classTarif unTarif)
        {
            leTarif = unTarif;
        }
    }
}
