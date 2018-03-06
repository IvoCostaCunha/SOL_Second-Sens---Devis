using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classPersonnalisation
    {
        private String leLibPerso;
        private double leTarifPersonnalisation;

        /// <summary>
        /// Constructeur de la classe classPersonnalisation
        /// </summary>
        /// <param name="unLibPerso"></param>
        /// <param name="unTarifPersonnalisation"></param>
        public classPersonnalisation(String unLibPerso, double unTarifPersonnalisation)
        {
            this.leLibPerso = unLibPerso;
            this.leTarifPersonnalisation = unTarifPersonnalisation;
        }

        /// <summary>
        /// Constructeur de la classe classPersonnalisation nouvelle personnalisation
        /// </summary>
        /// <param name="unLibPerso">Libelle de la personnalisation</param>
        public classPersonnalisation(String unLibPerso)
        {
            this.leLibPerso = unLibPerso;
        }

        /// <summary>
        /// Fonction qui retourne le libelle de l'objet courant
        /// </summary>
        /// <returns></returns>
        public String getLibPersonnalisation()
        {
            return this.leLibPerso;
        }

        /// <summary>
        /// Fonction qui retourne le tarif de l'objet courant
        /// </summary>
        /// <returns></returns>
        public double getTarifPersonnalisation()
        {
            return this.leTarifPersonnalisation;
        }

        /// <summary>
        /// Méthode qui set le tarif de la personnalisation
        /// <param name="unTarifPersonnalisation">Le tarif de la personnalisation</param>
        /// </summary>
        public void setTarifPersonnalisation(double unTarifPersonnalisation)
        {
            this.leTarifPersonnalisation = unTarifPersonnalisation;
        }
    }
}