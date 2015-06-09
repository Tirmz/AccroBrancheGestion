namespace ApplicationAccrobrancheProper
{
    partial class FrmModifFournisseur
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
            this.bt_validateModif = new System.Windows.Forms.Button();
            this.txt_cpfour = new System.Windows.Forms.TextBox();
            this.txt_villefour = new System.Windows.Forms.TextBox();
            this.txt_namefour = new System.Windows.Forms.TextBox();
            this.lb_cpfour = new System.Windows.Forms.Label();
            this.lb_villefour = new System.Windows.Forms.Label();
            this.lb_namefour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_validateModif
            // 
            this.bt_validateModif.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_validateModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_validateModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_validateModif.ForeColor = System.Drawing.Color.White;
            this.bt_validateModif.Location = new System.Drawing.Point(115, 178);
            this.bt_validateModif.Name = "bt_validateModif";
            this.bt_validateModif.Size = new System.Drawing.Size(110, 36);
            this.bt_validateModif.TabIndex = 13;
            this.bt_validateModif.Text = "Valider";
            this.bt_validateModif.UseVisualStyleBackColor = false;
            this.bt_validateModif.Click += new System.EventHandler(this.bt_validateModif_Click);
            // 
            // txt_cpfour
            // 
            this.txt_cpfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpfour.Location = new System.Drawing.Point(185, 128);
            this.txt_cpfour.Name = "txt_cpfour";
            this.txt_cpfour.Size = new System.Drawing.Size(198, 35);
            this.txt_cpfour.TabIndex = 12;
            // 
            // txt_villefour
            // 
            this.txt_villefour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_villefour.Location = new System.Drawing.Point(115, 84);
            this.txt_villefour.Name = "txt_villefour";
            this.txt_villefour.Size = new System.Drawing.Size(268, 35);
            this.txt_villefour.TabIndex = 11;
            // 
            // txt_namefour
            // 
            this.txt_namefour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namefour.Location = new System.Drawing.Point(115, 36);
            this.txt_namefour.Name = "txt_namefour";
            this.txt_namefour.Size = new System.Drawing.Size(268, 35);
            this.txt_namefour.TabIndex = 10;
            // 
            // lb_cpfour
            // 
            this.lb_cpfour.AutoSize = true;
            this.lb_cpfour.BackColor = System.Drawing.Color.Transparent;
            this.lb_cpfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpfour.ForeColor = System.Drawing.Color.White;
            this.lb_cpfour.Location = new System.Drawing.Point(22, 131);
            this.lb_cpfour.Name = "lb_cpfour";
            this.lb_cpfour.Size = new System.Drawing.Size(157, 29);
            this.lb_cpfour.TabIndex = 9;
            this.lb_cpfour.Text = "Code Postal :";
            // 
            // lb_villefour
            // 
            this.lb_villefour.AutoSize = true;
            this.lb_villefour.BackColor = System.Drawing.Color.Transparent;
            this.lb_villefour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_villefour.ForeColor = System.Drawing.Color.White;
            this.lb_villefour.Location = new System.Drawing.Point(22, 87);
            this.lb_villefour.Name = "lb_villefour";
            this.lb_villefour.Size = new System.Drawing.Size(78, 29);
            this.lb_villefour.TabIndex = 8;
            this.lb_villefour.Text = "Ville : ";
            // 
            // lb_namefour
            // 
            this.lb_namefour.AutoSize = true;
            this.lb_namefour.BackColor = System.Drawing.Color.Transparent;
            this.lb_namefour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namefour.ForeColor = System.Drawing.Color.White;
            this.lb_namefour.Location = new System.Drawing.Point(22, 39);
            this.lb_namefour.Name = "lb_namefour";
            this.lb_namefour.Size = new System.Drawing.Size(77, 29);
            this.lb_namefour.TabIndex = 7;
            this.lb_namefour.Text = "Nom :";
            // 
            // FrmModifFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(411, 226);
            this.Controls.Add(this.bt_validateModif);
            this.Controls.Add(this.txt_cpfour);
            this.Controls.Add(this.txt_villefour);
            this.Controls.Add(this.txt_namefour);
            this.Controls.Add(this.lb_cpfour);
            this.Controls.Add(this.lb_villefour);
            this.Controls.Add(this.lb_namefour);
            this.Name = "FrmModifFournisseur";
            this.Text = "Modifier un Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_validateModif;
        private System.Windows.Forms.TextBox txt_cpfour;
        private System.Windows.Forms.TextBox txt_villefour;
        private System.Windows.Forms.TextBox txt_namefour;
        private System.Windows.Forms.Label lb_cpfour;
        private System.Windows.Forms.Label lb_villefour;
        private System.Windows.Forms.Label lb_namefour;
    }
}