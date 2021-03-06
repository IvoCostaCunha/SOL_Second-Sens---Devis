﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Second_Sens___Devis
{
    public class classIndemKm
    {
        private int leNbCV;
        private double leCoef;
        private double leCoef2;
        private int leAn;
        private double leNbKmAn;

        /// <summary>
        /// Constructeur de la classe classIndem si prédefinie
        /// </summary>
        /// <param name="unNbCV"></param>
        /// <param name="unCoef"></param>
        /// <param name="unCoef2">Le 2eme coef de l'indemKm, si n'existe pas valoriser avec la valeur NULL</param>
        public classIndemKm(int unNbCV, double unCoef, double unCoef2, int unAn, double unNbKmAn)
        {
            this.leNbCV = unNbCV;
            this.leCoef = unCoef;
            this.leCoef2 = unCoef2;
            this.leAn = unAn;
            this.leNbKmAn = unNbKmAn;
        }

        /// <summary>
        /// Constructeur de la classe classIndem si le nb de CV du vehicule société concerné est connu
        /// </summary>
        /// <param name="unNbCV"></param>
        public classIndemKm(int unNbCV)
        {
            this.leNbCV = unNbCV;
        }

        /// <summary>
        /// Methode qui set le nb de CV du vehicule concerné
        /// </summary>
        /// <param name="unNbCV"></param>
        public void setNbCV(int unNbCV)
        {
            this.leNbCV = unNbCV;
        }

        /// <summary>
        /// Méthode qui set les coef de l'indemnité kilometrique
        /// </summary>
        /// <param name="unCoef"></param>
        /// <param name="unCoef2">Le 2eme coef de l'indemKm, si n'existe pas valoriser avec la valeur NULL</param>
        public void setCoef(double unCoef, double unCoef2)
        {
            this.leCoef = unCoef;
            this.leCoef2 = unCoef2;
        }
    }
}
