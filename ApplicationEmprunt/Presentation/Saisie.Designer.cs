namespace ApplicationEmprunt.Presentation
{
    partial class Saisie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_capital = new System.Windows.Forms.TextBox();
            this.txt_taux = new System.Windows.Forms.TextBox();
            this.txt_duree = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emprunt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saisir le capital :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saisir le taux :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saisir la durée :";
            // 
            // txt_capital
            // 
            this.txt_capital.Location = new System.Drawing.Point(204, 117);
            this.txt_capital.Name = "txt_capital";
            this.txt_capital.Size = new System.Drawing.Size(100, 20);
            this.txt_capital.TabIndex = 4;
            this.txt_capital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_capital_KeyPress);
            // 
            // txt_taux
            // 
            this.txt_taux.Location = new System.Drawing.Point(204, 163);
            this.txt_taux.Name = "txt_taux";
            this.txt_taux.Size = new System.Drawing.Size(58, 20);
            this.txt_taux.TabIndex = 5;
            this.txt_taux.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_taux_KeyPress);
            // 
            // txt_duree
            // 
            this.txt_duree.Location = new System.Drawing.Point(204, 215);
            this.txt_duree.Name = "txt_duree";
            this.txt_duree.Size = new System.Drawing.Size(100, 20);
            this.txt_duree.TabIndex = 6;
            this.txt_duree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_duree_KeyPress);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(204, 290);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 7;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "%";
            // 
            // Saisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 331);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_duree);
            this.Controls.Add(this.txt_taux);
            this.Controls.Add(this.txt_capital);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Saisie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Saisie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_capital;
        private System.Windows.Forms.TextBox txt_taux;
        private System.Windows.Forms.TextBox txt_duree;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label label5;
    }
}

