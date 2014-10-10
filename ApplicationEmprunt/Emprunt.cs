using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEmprunt
{
    public class Emprunt
    {

        #region Accesseurs
        private double capital;
        private double taux;
        private double ki = 0;
        private double ami;
        private double i;

        public double I
        {
            get { return i; }
            set { i = value; }
        }

        public double Taux
        {
            get { return taux; }
            set { taux = value; }
        }
        public double Ami
        {
            get { return ami; }
            set { ami = value; }
        }
        public double Ki
        {
            get { return ki; }
            set { ki = value; }
        }

        private double duree;
        private double tauxMois, tauxTrimestre, tauxSemaine;

        public double TauxSemaine
        {
            get { return tauxSemaine; }
            set { tauxSemaine = value; }
        }

        public double TauxTrimestre
        {
            get { return tauxTrimestre; }
            set { tauxTrimestre = value; }
        }

        public double TauxMois
        {
            get { return tauxMois; }
            set { tauxMois = value; }
        }

        private double echeanceMois, echeanceSemaine, echeanceTrimestre, echeanceAnnee;

        public double EcheanceAnnee
        {
            get { return echeanceAnnee; }
            set { echeanceAnnee = value; }
        }

        public double EcheanceTrimestre
        {
            get { return echeanceTrimestre; }
            set { echeanceTrimestre = value; }
        }

        public double EcheanceSemaine
        {
            get { return echeanceSemaine; }
            set { echeanceSemaine = value; }
        }

        public double EcheanceMois
        {
            get { return echeanceMois; }
            set { echeanceMois = value; }
        }

        private double dureeMois, dureeSemaine, dureeTrimestre;

        #endregion

        public Emprunt(Double capital,Double taux, Double duree)
        {
            this.capital = capital;
            this.taux = taux;
            this.duree = duree;
            equivalenceTaux();
            equivalenceDuree();
            calculerEmprunt();
        }

        public void equivalenceTaux()
        {
                this.tauxMois = (Math.Pow(this.taux + 1.0, 1.0 / 12.0)) - 1.0;
                this.tauxSemaine = (Math.Pow(this.taux + 1.0, 1.0 / 52.0)) - 1.0;
                this.tauxTrimestre = (Math.Pow(this.taux + 1.0, 1.0 / 4.0)) - 1.0;
        }

        public void equivalenceDuree()
        {
            this.dureeMois = this.duree * 12;
            this.dureeSemaine = this.duree * 52;
            this.dureeTrimestre = this.duree * 4;
        }

        public void calculerEmprunt()
        {
            this.echeanceAnnee = (capital * taux) / (1.0 - (Math.Pow(1 + taux, -duree)));
            this.echeanceSemaine = (capital * tauxSemaine) /
                (1.0 - (Math.Pow(1 + tauxSemaine, -dureeSemaine)));
            this.echeanceMois = (capital * tauxMois) /
                (1.0 - (Math.Pow(1 + tauxMois, -dureeMois)));
            this.echeanceTrimestre = (capital * tauxTrimestre) /
                (1.0 - (Math.Pow(1 + tauxTrimestre, -dureeTrimestre)));
        }
        public void calculerDataGrid()
        {
            if(this.ki == 0)
                this.ki = this.capital;
            else
                this.ki = this.ki - this.ami;
            this.i = this.tauxMois * this.ki;
            this.ami = this.echeanceMois - this.i;
        }

        // A = K x r / 1 - (1 + r)-^N

        // Equivalence : lm = (lq + 1)^1/K - 1



    }
}
