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
    public partial class Index : Form
    {
        private static Emprunt unEmprunt;

        public static Emprunt UnEmprunt
        {
            get { return unEmprunt; }
            set { unEmprunt = value; }
        }
        public Index()
        {
            InitializeComponent();
        }

        private void nouvelEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saisie uneSaisie = new Saisie();
            uneSaisie.Show();
        }

        private void dataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid dgv = new DataGrid(UnEmprunt);
            dgv.Show();
        }

        private void resultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultat r = new Resultat(UnEmprunt);
            r.Show();
        }

        private void empruntToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (UnEmprunt != null)
            {
                resultatToolStripMenuItem.Enabled = true;
                dataGridToolStripMenuItem.Enabled = true;
            }
        }


    }
}
