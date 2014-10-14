namespace ApplicationEmprunt.Presentation
{
    partial class Index
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
            this.menuAcceuil = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAcceuil
            // 
            this.menuAcceuil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.empruntToolStripMenuItem});
            this.menuAcceuil.Location = new System.Drawing.Point(0, 0);
            this.menuAcceuil.Name = "menuAcceuil";
            this.menuAcceuil.Size = new System.Drawing.Size(346, 24);
            this.menuAcceuil.TabIndex = 0;
            this.menuAcceuil.Text = "menuAcceuil";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // empruntToolStripMenuItem
            // 
            this.empruntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelEmpruntToolStripMenuItem,
            this.resultatToolStripMenuItem,
            this.dataGridToolStripMenuItem});
            this.empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            this.empruntToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.empruntToolStripMenuItem.Text = "Emprunt";
            this.empruntToolStripMenuItem.MouseEnter += new System.EventHandler(this.empruntToolStripMenuItem_MouseEnter);
            // 
            // nouvelEmpruntToolStripMenuItem
            // 
            this.nouvelEmpruntToolStripMenuItem.Name = "nouvelEmpruntToolStripMenuItem";
            this.nouvelEmpruntToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nouvelEmpruntToolStripMenuItem.Text = "Nouvel Emprunt";
            this.nouvelEmpruntToolStripMenuItem.Click += new System.EventHandler(this.nouvelEmpruntToolStripMenuItem_Click);
            // 
            // resultatToolStripMenuItem
            // 
            this.resultatToolStripMenuItem.Enabled = false;
            this.resultatToolStripMenuItem.Name = "resultatToolStripMenuItem";
            this.resultatToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.resultatToolStripMenuItem.Text = "Resultat";
            this.resultatToolStripMenuItem.Click += new System.EventHandler(this.resultatToolStripMenuItem_Click);
            // 
            // dataGridToolStripMenuItem
            // 
            this.dataGridToolStripMenuItem.Enabled = false;
            this.dataGridToolStripMenuItem.Name = "dataGridToolStripMenuItem";
            this.dataGridToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.dataGridToolStripMenuItem.Text = "DataGrid";
            this.dataGridToolStripMenuItem.Click += new System.EventHandler(this.dataGridToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationEmprunt.Properties.Resources.article;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 294);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuAcceuil);
            this.MainMenuStrip = this.menuAcceuil;
            this.Name = "Index";
            this.Text = "Index";
            this.menuAcceuil.ResumeLayout(false);
            this.menuAcceuil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGridToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuAcceuil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}