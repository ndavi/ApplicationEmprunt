namespace ApplicationEmprunt.Presentation
{
    partial class DataGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Amortissement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intérêt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annuité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_datagrid = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amortissement,
            this.Intérêt,
            this.Annuité,
            this.Capital});
            this.dgv.Location = new System.Drawing.Point(-1, 1);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(491, 428);
            this.dgv.TabIndex = 0;
            // 
            // Amortissement
            // 
            this.Amortissement.HeaderText = "Amortissement";
            this.Amortissement.Name = "Amortissement";
            this.Amortissement.ReadOnly = true;
            // 
            // Intérêt
            // 
            this.Intérêt.HeaderText = "Intérêt";
            this.Intérêt.Name = "Intérêt";
            this.Intérêt.ReadOnly = true;
            // 
            // Annuité
            // 
            this.Annuité.HeaderText = "Annuité";
            this.Annuité.Name = "Annuité";
            this.Annuité.ReadOnly = true;
            // 
            // Capital
            // 
            this.Capital.HeaderText = "Capital restant";
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            // 
            // cbx_datagrid
            // 
            this.cbx_datagrid.DisplayMember = "12";
            this.cbx_datagrid.FormattingEnabled = true;
            this.cbx_datagrid.Items.AddRange(new object[] {
            "Calcul par année",
            "Calcul par mois",
            "Calcul par trimestre",
            "Calcul par semaine"});
            this.cbx_datagrid.Location = new System.Drawing.Point(496, 12);
            this.cbx_datagrid.Name = "cbx_datagrid";
            this.cbx_datagrid.Size = new System.Drawing.Size(109, 21);
            this.cbx_datagrid.TabIndex = 1;
            this.cbx_datagrid.SelectedIndexChanged += new System.EventHandler(this.cbx_datagrid_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(496, 68);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(109, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Fermer";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(496, 39);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 429);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cbx_datagrid);
            this.Controls.Add(this.dgv);
            this.Name = "DataGrid";
            this.Text = "DataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amortissement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intérêt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annuité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.ComboBox cbx_datagrid;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btnExport;
    }
}