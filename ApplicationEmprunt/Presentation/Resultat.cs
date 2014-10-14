using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationEmprunt.Presentation
{
    public partial class Resultat : Form
    {
        public Resultat(Emprunt unEmprunt)
        {
            InitializeComponent();
            lbl_taux_annee.Text = Convert.ToString(Math.Round(unEmprunt.Taux * 100,2)) + " %";
            lbl_taux_mois.Text = Convert.ToString(Math.Round(unEmprunt.TauxMois * 100,2)) + " %";
            lbl_taux_semaine.Text = Convert.ToString(Math.Round(unEmprunt.TauxSemaine * 100,2)) + " %";
            lbl_taux_trimestre.Text = Convert.ToString(Math.Round(unEmprunt.TauxTrimestre * 100,2)) + " %";

            lbl_echeance_mois.Text = Convert.ToString(Math.Round(unEmprunt.EcheanceMois,2)) + " €";
            lbl_echeance_semaine.Text = Convert.ToString(Math.Round(unEmprunt.EcheanceSemaine,2)) + " €";
            lbl_echeance_trimestre.Text = Convert.ToString(Math.Round(unEmprunt.EcheanceTrimestre,2)) + " €";
            lbl_echeance_annee.Text = Convert.ToString(Math.Round(unEmprunt.EcheanceAnnee,2)) + " €";
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
