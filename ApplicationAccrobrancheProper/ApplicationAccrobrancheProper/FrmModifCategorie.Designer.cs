namespace ApplicationAccrobrancheProper
{
    partial class FrmModifCategorie
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
            this.txt_nameCategorie = new System.Windows.Forms.TextBox();
            this.lb_nameCategorie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_validateModif
            // 
            this.bt_validateModif.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_validateModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_validateModif.ForeColor = System.Drawing.Color.White;
            this.bt_validateModif.Location = new System.Drawing.Point(108, 72);
            this.bt_validateModif.Name = "bt_validateModif";
            this.bt_validateModif.Size = new System.Drawing.Size(119, 33);
            this.bt_validateModif.TabIndex = 16;
            this.bt_validateModif.Text = "Valider";
            this.bt_validateModif.UseVisualStyleBackColor = false;
            this.bt_validateModif.Click += new System.EventHandler(this.bt_validateModif_Click);
            // 
            // txt_nameCategorie
            // 
            this.txt_nameCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameCategorie.Location = new System.Drawing.Point(108, 19);
            this.txt_nameCategorie.Name = "txt_nameCategorie";
            this.txt_nameCategorie.Size = new System.Drawing.Size(259, 35);
            this.txt_nameCategorie.TabIndex = 15;
            // 
            // lb_nameCategorie
            // 
            this.lb_nameCategorie.AutoSize = true;
            this.lb_nameCategorie.BackColor = System.Drawing.Color.Transparent;
            this.lb_nameCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameCategorie.ForeColor = System.Drawing.Color.White;
            this.lb_nameCategorie.Location = new System.Drawing.Point(9, 22);
            this.lb_nameCategorie.Name = "lb_nameCategorie";
            this.lb_nameCategorie.Size = new System.Drawing.Size(77, 29);
            this.lb_nameCategorie.TabIndex = 14;
            this.lb_nameCategorie.Text = "Nom :";
            // 
            // FrmModifCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(393, 117);
            this.Controls.Add(this.bt_validateModif);
            this.Controls.Add(this.txt_nameCategorie);
            this.Controls.Add(this.lb_nameCategorie);
            this.Name = "FrmModifCategorie";
            this.Text = "Modifier une Catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_validateModif;
        private System.Windows.Forms.TextBox txt_nameCategorie;
        private System.Windows.Forms.Label lb_nameCategorie;
    }
}