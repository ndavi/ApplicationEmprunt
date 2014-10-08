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
        }

        public void LoadData()
        {
            this.dgv.Rows.Clear();
        }
    }
}
