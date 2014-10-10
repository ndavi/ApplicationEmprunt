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
        public DataGrid(Emprunt unEmprunt)
        {
            InitializeComponent();
            LoadData(unEmprunt);
        }

        public void LoadData(Emprunt unEmprunt)
        {
            this.dgv.Rows.Clear();
            unEmprunt.calculerDataGrid();
            this.dgv.Rows.Add(unEmprunt.Ami,unEmprunt.I,unEmprunt.Ami,"",unEmprunt.Ki);
        }
    }
}
