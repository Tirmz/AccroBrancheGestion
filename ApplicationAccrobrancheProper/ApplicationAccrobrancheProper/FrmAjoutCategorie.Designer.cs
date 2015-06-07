namespace ApplicationAccrobrancheProper
{
    partial class FrmAjoutCategorie
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
            this.lb_nameCategorie = new System.Windows.Forms.Label();
            this.txt_nameCategorie = new System.Windows.Forms.TextBox();
            this.bt_validateAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nameCategorie
            // 
            this.lb_nameCategorie.AutoSize = true;
            this.lb_nameCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameCategorie.Location = new System.Drawing.Point(12, 30);
            this.lb_nameCategorie.Name = "lb_nameCategorie";
            this.lb_nameCategorie.Size = new System.Drawing.Size(77, 29);
            this.lb_nameCategorie.TabIndex = 0;
            this.lb_nameCategorie.Text = "Nom :";
            // 
            // txt_nameCategorie
            // 
            this.txt_nameCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameCategorie.Location = new System.Drawing.Point(111, 27);
            this.txt_nameCategorie.Name = "txt_nameCategorie";
            this.txt_nameCategorie.Size = new System.Drawing.Size(205, 35);
            this.txt_nameCategorie.TabIndex = 1;
            // 
            // bt_validateAjout
            // 
            this.bt_validateAjout.Location = new System.Drawing.Point(143, 80);
            this.bt_validateAjout.Name = "bt_validateAjout";
            this.bt_validateAjout.Size = new System.Drawing.Size(89, 26);
            this.bt_validateAjout.TabIndex = 13;
            this.bt_validateAjout.Text = "Valider";
            this.bt_validateAjout.UseVisualStyleBackColor = true;
            this.bt_validateAjout.Click += new System.EventHandler(this.bt_validateAjout_Click);
            // 
            // FrmAjoutCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 118);
            this.Controls.Add(this.bt_validateAjout);
            this.Controls.Add(this.txt_nameCategorie);
            this.Controls.Add(this.lb_nameCategorie);
            this.Name = "FrmAjoutCategorie";
            this.Text = "Ajouter une Catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nameCategorie;
        private System.Windows.Forms.TextBox txt_nameCategorie;
        private System.Windows.Forms.Button bt_validateAjout;
    }
}