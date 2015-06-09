namespace ApplicationAccrobrancheProper
{
    partial class FrmAjoutFournisseur
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
            this.lb_namefour = new System.Windows.Forms.Label();
            this.lb_villefour = new System.Windows.Forms.Label();
            this.lb_cpfour = new System.Windows.Forms.Label();
            this.txt_namefour = new System.Windows.Forms.TextBox();
            this.txt_villefour = new System.Windows.Forms.TextBox();
            this.txt_cpfour = new System.Windows.Forms.TextBox();
            this.bt_validateAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_namefour
            // 
            this.lb_namefour.AutoSize = true;
            this.lb_namefour.BackColor = System.Drawing.Color.Transparent;
            this.lb_namefour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namefour.ForeColor = System.Drawing.Color.White;
            this.lb_namefour.Location = new System.Drawing.Point(12, 43);
            this.lb_namefour.Name = "lb_namefour";
            this.lb_namefour.Size = new System.Drawing.Size(77, 29);
            this.lb_namefour.TabIndex = 0;
            this.lb_namefour.Text = "Nom :";
            // 
            // lb_villefour
            // 
            this.lb_villefour.AutoSize = true;
            this.lb_villefour.BackColor = System.Drawing.Color.Transparent;
            this.lb_villefour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_villefour.ForeColor = System.Drawing.Color.White;
            this.lb_villefour.Location = new System.Drawing.Point(12, 91);
            this.lb_villefour.Name = "lb_villefour";
            this.lb_villefour.Size = new System.Drawing.Size(78, 29);
            this.lb_villefour.TabIndex = 1;
            this.lb_villefour.Text = "Ville : ";
            // 
            // lb_cpfour
            // 
            this.lb_cpfour.AutoSize = true;
            this.lb_cpfour.BackColor = System.Drawing.Color.Transparent;
            this.lb_cpfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpfour.ForeColor = System.Drawing.Color.White;
            this.lb_cpfour.Location = new System.Drawing.Point(12, 135);
            this.lb_cpfour.Name = "lb_cpfour";
            this.lb_cpfour.Size = new System.Drawing.Size(157, 29);
            this.lb_cpfour.TabIndex = 2;
            this.lb_cpfour.Text = "Code Postal :";
            // 
            // txt_namefour
            // 
            this.txt_namefour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namefour.Location = new System.Drawing.Point(105, 40);
            this.txt_namefour.Name = "txt_namefour";
            this.txt_namefour.Size = new System.Drawing.Size(187, 35);
            this.txt_namefour.TabIndex = 3;
            // 
            // txt_villefour
            // 
            this.txt_villefour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_villefour.Location = new System.Drawing.Point(105, 88);
            this.txt_villefour.Name = "txt_villefour";
            this.txt_villefour.Size = new System.Drawing.Size(187, 35);
            this.txt_villefour.TabIndex = 4;
            // 
            // txt_cpfour
            // 
            this.txt_cpfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpfour.Location = new System.Drawing.Point(175, 132);
            this.txt_cpfour.Name = "txt_cpfour";
            this.txt_cpfour.Size = new System.Drawing.Size(117, 35);
            this.txt_cpfour.TabIndex = 5;
            // 
            // bt_validateAjout
            // 
            this.bt_validateAjout.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_validateAjout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_validateAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_validateAjout.ForeColor = System.Drawing.Color.White;
            this.bt_validateAjout.Location = new System.Drawing.Point(105, 173);
            this.bt_validateAjout.Name = "bt_validateAjout";
            this.bt_validateAjout.Size = new System.Drawing.Size(99, 38);
            this.bt_validateAjout.TabIndex = 6;
            this.bt_validateAjout.Text = "Valider";
            this.bt_validateAjout.UseVisualStyleBackColor = false;
            this.bt_validateAjout.Click += new System.EventHandler(this.bt_validateAjout_Click);
            // 
            // FrmAjoutFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(324, 217);
            this.Controls.Add(this.bt_validateAjout);
            this.Controls.Add(this.txt_cpfour);
            this.Controls.Add(this.txt_villefour);
            this.Controls.Add(this.txt_namefour);
            this.Controls.Add(this.lb_cpfour);
            this.Controls.Add(this.lb_villefour);
            this.Controls.Add(this.lb_namefour);
            this.Name = "FrmAjoutFournisseur";
            this.Text = "Ajouter un Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_namefour;
        private System.Windows.Forms.Label lb_villefour;
        private System.Windows.Forms.Label lb_cpfour;
        private System.Windows.Forms.TextBox txt_namefour;
        private System.Windows.Forms.TextBox txt_villefour;
        private System.Windows.Forms.TextBox txt_cpfour;
        private System.Windows.Forms.Button bt_validateAjout;
    }
}