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

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Passage du dgv sur excel
            if (dgv.ColumnCount == 0)
            {
                MessageBox.Show("Aucune données à exporter !", "Erreur !", MessageBoxButtons.OK);
            }
            if (dgv.RowCount == 0)
            {
                MessageBox.Show("Aucune données à exporter !", "Erreur !", MessageBoxButtons.OK);
            }
            //DataSet pour récuperer les données
            DataSet myDs = new DataSet();
            //Ajout des tables au ds
            myDs.Tables.Add();
            //Ajout des colonnes aux tables
            for (int i = 0; i <= dgv.ColumnCount - 1; i++)
            { myDs.Tables[0].Columns.Add(); }
            //Ajout des lignes aux tables
            DataRow myDrw;
            for (int i = 0; i <= dgv.RowCount - 1; i++)
            {
                myDrw = myDs.Tables[0].NewRow();
                for (int j = 0; j <= dgv.ColumnCount - 1; j++)
                {
                    myDrw[j] = dgv.Rows[i].Cells[j].Value;
                }
                myDs.Tables[0].Rows.Add(myDrw);
            }
            Microsoft.Office.Interop.Excel.Application myExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wBook;
            Microsoft.Office.Interop.Excel.Worksheet wSheet;
            object oMissing = System.Reflection.Missing.Value;
            wBook = myExcel.Workbooks.Add(oMissing);
            wSheet = (Microsoft.Office.Interop.Excel.Worksheet)wBook.ActiveSheet;

            System.Data.DataTable myDt = myDs.Tables[0];
            int col = 0; int row = 0;
            foreach (DataColumn Dc in myDt.Columns)
            {              
                col = col + 1;
                if (col == 1) Dc.ColumnName = "Ammortissement";
                else if (col == 2) Dc.ColumnName = "Interet";
                else if (col == 3) Dc.ColumnName = "Annuité";
                else if (col == 4) Dc.ColumnName = "Capital Restant";
                myExcel.Cells[1, col] = Dc.ColumnName;
            }
            foreach (DataRow Dr in myDt.Rows)
            {
                row = row + 1;
                col = 0;
                foreach (DataColumn Dc in myDt.Columns)
                {
                    col = col + 1;
                    myExcel.Cells[row + 1, col] = Convert.ToDouble(Dr[Dc.ColumnName]);
                }
            }
            wSheet.Columns.AutoFit();
            string myFileName = "M:\\export.xls";
            //Tentative de création du fichier ainsi que de l'ouverture de ce fichier.
            //Si le fichier existe déjà il est supprimé si les droits le permettent
            try
            {
                System.IO.FileStream fileTemp = System.IO.File.OpenWrite(myFileName);
                fileTemp.Close();
                if (System.IO.File.Exists(myFileName))
                        System.IO.File.Delete(myFileName);
                        wBook.SaveAs(myFileName);
                        myExcel.Workbooks.Open(myFileName);
                        myExcel.Visible = true;
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Erreur lors de l'exportation \n\t " + ex.Message, "Erreur Export");
            }     
        }
    }
}
