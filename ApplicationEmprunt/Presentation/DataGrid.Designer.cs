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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amortissement,
            this.Intérêt,
            this.Annuité,
            this.Capital});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(617, 429);
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
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 429);
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
    }
}