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
    public partial class DataGrid : Form
    {
        private static Emprunt unEmprunt;
        public DataGrid(Emprunt emprunt)
        {
            InitializeComponent();
            unEmprunt = emprunt;
            cbx_datagrid.SelectedIndex = 0;
            LoadData();
        }

        public void LoadData()
        {
            this.dgv.Rows.Clear();
            unEmprunt.reinitialiserDataGrid();
            for (int i = 1; i <= unEmprunt.Duree; i++)
            {
                unEmprunt.calculerDataGrid();
                this.dgv.Rows.Add(Math.Round(unEmprunt.Ami,2),
                    Math.Round(unEmprunt.I,2),
                    Math.Round(unEmprunt.EcheanceAnnee,2),
                    Math.Round(unEmprunt.Ki,2));
            }
        }

        public void LoadDataMois()
        {
            this.dgv.Rows.Clear();
            unEmprunt.reinitialiserDataGrid();
            for (int i = 1; i <= unEmprunt.DureeMois; i++)
            {
                unEmprunt.calculerDataGridMois();
                this.dgv.Rows.Add(Math.Round(unEmprunt.Ami, 2),
                    Math.Round(unEmprunt.I, 2),
                    Math.Round(unEmprunt.EcheanceMois, 2),
                    Math.Round(unEmprunt.Ki, 2));
            }
        }
        public void LoadDataTrimestre()
        {
            this.dgv.Rows.Clear();
            unEmprunt.reinitialiserDataGrid();
            for (int i = 1; i <= unEmprunt.DureeTrimestre; i++)
            {
                unEmprunt.calculerDataGridTrimestre();
                this.dgv.Rows.Add(Math.Round(unEmprunt.Ami, 2),
                    Math.Round(unEmprunt.I, 2),
                    Math.Round(unEmprunt.EcheanceTrimestre, 2),
                    Math.Round(unEmprunt.Ki, 2));
            }
        }
        public void LoadDataSemaine()
        {
            this.dgv.Rows.Clear();
            unEmprunt.reinitialiserDataGrid();
            for (int i = 1; i <= unEmprunt.DureeSemaine; i++)
            {
                unEmprunt.calculerDataGridSemaine();
                this.dgv.Rows.Add(Math.Round(unEmprunt.Ami, 2),
                    Math.Round(unEmprunt.I, 2),
                    Math.Round(unEmprunt.EcheanceSemaine, 2),
                    Math.Round(unEmprunt.Ki, 2));
            }
        }

        private void cbx_datagrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_datagrid.SelectedIndex == 0)
                this.LoadData();
            else if (cbx_datagrid.SelectedIndex == 1)
                this.LoadDataMois();
            else if (cbx_datagrid.SelectedIndex == 2)
                this.LoadDataTrimestre();
            else if (cbx_datagrid.SelectedIndex == 3)
                this.LoadDataSemaine();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
