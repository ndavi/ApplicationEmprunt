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
            lbl_taux_annee.Text = Convert.ToString(unEmprunt.Taux * 100) + " %";
            lbl_taux_mois.Text = Convert.ToString(unEmprunt.TauxMois * 100) + " %";
            lbl_taux_semaine.Text = Convert.ToString(unEmprunt.TauxSemaine * 100) + " %";
            lbl_taux_trimestre.Text = Convert.ToString(unEmprunt.TauxTrimestre * 100) + " %";

            lbl_echeance_mois.Text = Convert.ToString(unEmprunt.EcheanceMois) + " €";
            lbl_echeance_semaine.Text = Convert.ToString(unEmprunt.EcheanceSemaine) + " €";
            lbl_echeance_trimestre.Text = Convert.ToString(unEmprunt.EcheanceTrimestre) + " €";
            lbl_echeance_annee.Text = Convert.ToString(unEmprunt.EcheanceAnnee) + " €";
        }

    }
}
