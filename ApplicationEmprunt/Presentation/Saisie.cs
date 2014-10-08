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
    public partial class Saisie : Form
    {
        public Saisie()
        {
            InitializeComponent();

        }

        private void Saisie_Load(object sender, EventArgs e)
        {

        }

        private void txt_capital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_taux_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar == Convert.ToChar(".")) || (e.KeyChar == Convert.ToChar(","))) &&
                (txt_taux.Text.Contains(".") || txt_taux.Text.Contains(",")))
            {
                e.Handled = true;
                ToolTip tooltipTaux = new ToolTip();
                tooltipTaux.RemoveAll();
                tooltipTaux.Show("Vous avez déjà saisi une virgule",txt_taux);
            }
            else if (e.KeyChar == Convert.ToChar("."))
                e.KeyChar = Convert.ToChar(",");
            else if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && Convert.ToChar(",") != e.KeyChar)
            {
                e.Handled = true;
            }
            
        }

        private void txt_duree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            Emprunt unEmprunt = new Emprunt(
                Convert.ToDouble(txt_capital.Text),
                Convert.ToDouble(txt_taux.Text) / 100,
                Convert.ToDouble(txt_duree.Text));
            Resultat r = new Resultat(unEmprunt);
            Index.UnEmprunt = unEmprunt;
            r.Show();
            this.Close();
        }



    }
}
