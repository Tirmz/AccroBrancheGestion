namespace ApplicationAccrobrancheProper
{
    partial class FrmModifProduit
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
            this.bt_validateAjout = new System.Windows.Forms.Button();
            this.cbx_fournisseur = new System.Windows.Forms.ComboBox();
            this.cbx_categorie = new System.Windows.Forms.ComboBox();
            this.num_alert = new System.Windows.Forms.NumericUpDown();
            this.num_quantite = new System.Windows.Forms.NumericUpDown();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.txt_nameProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_alert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantite)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_validateAjout
            // 
            this.bt_validateAjout.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_validateAjout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_validateAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_validateAjout.ForeColor = System.Drawing.Color.White;
            this.bt_validateAjout.Location = new System.Drawing.Point(108, 279);
            this.bt_validateAjout.Name = "bt_validateAjout";
            this.bt_validateAjout.Size = new System.Drawing.Size(120, 36);
            this.bt_validateAjout.TabIndex = 25;
            this.bt_validateAjout.Text = "Modifier";
            this.bt_validateAjout.UseVisualStyleBackColor = false;
            this.bt_validateAjout.Click += new System.EventHandler(this.bt_validateAjout_Click);
            // 
            // cbx_fournisseur
            // 
            this.cbx_fournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_fournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fournisseur.FormattingEnabled = true;
            this.cbx_fournisseur.Location = new System.Drawing.Point(175, 234);
            this.cbx_fournisseur.Name = "cbx_fournisseur";
            this.cbx_fournisseur.Size = new System.Drawing.Size(232, 28);
            this.cbx_fournisseur.TabIndex = 24;
            // 
            // cbx_categorie
            // 
            this.cbx_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categorie.FormattingEnabled = true;
            this.cbx_categorie.Location = new System.Drawing.Point(175, 197);
            this.cbx_categorie.Name = "cbx_categorie";
            this.cbx_categorie.Size = new System.Drawing.Size(232, 28);
            this.cbx_categorie.TabIndex = 23;
            // 
            // num_alert
            // 
            this.num_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_alert.Location = new System.Drawing.Point(177, 161);
            this.num_alert.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_alert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_alert.Name = "num_alert";
            this.num_alert.Size = new System.Drawing.Size(230, 26);
            this.num_alert.TabIndex = 22;
            this.num_alert.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_quantite
            // 
            this.num_quantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_quantite.Location = new System.Drawing.Point(177, 129);
            this.num_quantite.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_quantite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_quantite.Name = "num_quantite";
            this.num_quantite.Size = new System.Drawing.Size(230, 26);
            this.num_quantite.TabIndex = 21;
            this.num_quantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_prix
            // 
            this.txt_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix.Location = new System.Drawing.Point(175, 88);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(232, 26);
            this.txt_prix.TabIndex = 20;
            // 
            // txt_nameProduct
            // 
            this.txt_nameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameProduct.Location = new System.Drawing.Point(175, 52);
            this.txt_nameProduct.Name = "txt_nameProduct";
            this.txt_nameProduct.Size = new System.Drawing.Size(232, 26);
            this.txt_nameProduct.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fournisseur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Catégorie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Seuil d\'Alerte :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantité Initiale :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prix HT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom Produit :";
            // 
            // FrmModifProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(443, 334);
            this.Controls.Add(this.bt_validateAjout);
            this.Controls.Add(this.cbx_fournisseur);
            this.Controls.Add(this.cbx_categorie);
            this.Controls.Add(this.num_alert);
            this.Controls.Add(this.num_quantite);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.txt_nameProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifProduit";
            this.Text = "Modifier un Produit";
            this.Load += new System.EventHandler(this.FrmModifProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_alert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_validateAjout;
        private System.Windows.Forms.ComboBox cbx_fournisseur;
        private System.Windows.Forms.ComboBox cbx_categorie;
        private System.Windows.Forms.NumericUpDown num_alert;
        private System.Windows.Forms.NumericUpDown num_quantite;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.TextBox txt_nameProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}