using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classTarif
    {
        private double leTarifTotalHeure;
        private double leTarifRevientHeure;
        private double leTarifMargeHeure;

        private double leTarifTotalJour;
        private double leTarifRevientJour;
        private double leTarifMargeJour;

        /// <summary>
        /// Constructeur de la classe classTarif
        /// </summary>
        /// <param name="unTarifTotalHeure"></param>
        /// <param name="unTarifRevientHeure"></param>
        /// <param name="unTarifMargeHeure"></param>
        /// <param name="unTarifTotalJour"></param>
        /// <param name="unTarifRevientJour"></param>
        /// <param name="unTarifMargeJour"></param>
        public classTarif(double unTarifTotalHeure, double unTarifRevientHeure, double unTarifMargeHeure, double unTarifTotalJour, double unTarifRevientJour, double unTarifMargeJour)
        {
            leTarifTotalHeure = unTarifTotalHeure;
            leTarifRevientHeure = unTarifRevientHeure;
            leTarifMargeHeure = unTarifMargeHeure;

            leTarifTotalJour = unTarifTotalJour;
            leTarifRevientJour = unTarifRevientJour;
            leTarifMargeJour = unTarifMargeJour;
        }

        public void setTarifTotalHeure(double unTarifTotalHeure)
        {
            this.leTarifTotalHeure = unTarifTotalHeure;
        }

        public void setTarifRevientHeure(double unTarifRevientHeure)
        {
            this.leTarifRevientHeure = unTarifRevientHeure;
        }

        public void setTarifMargeHeure(double unTarifMargeHeure)
        {
            this.leTarifMargeHeure = unTarifMargeHeure;
        }

        public void setTarifTotalJour(double unTarifTotalJour)
        {
            this.leTarifTotalJour = unTarifTotalJour;
        }

        public void setTarifRevientJour(double unTarifRevientJour)
        {
            this.leTarifRevientJour = unTarifRevientJour;
        }

        public void setTarifMargeJour(double unTarifMargeJour)
        {
            this.leTarifMargeJour = unTarifMargeJour;
        }
    }
}
