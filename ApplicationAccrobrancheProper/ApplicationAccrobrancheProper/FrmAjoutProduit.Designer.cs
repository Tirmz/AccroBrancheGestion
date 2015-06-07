namespace ApplicationAccrobrancheProper
{
    partial class FrmAjoutProduit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nameProduct = new System.Windows.Forms.TextBox();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.num_quantite = new System.Windows.Forms.NumericUpDown();
            this.num_alert = new System.Windows.Forms.NumericUpDown();
            this.cbx_categorie = new System.Windows.Forms.ComboBox();
            this.cbx_fournisseur = new System.Windows.Forms.ComboBox();
            this.bt_validateAjout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_alert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix HT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité Initiale :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seuil d\'Alerte :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Catégorie :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fournisseur";
            // 
            // txt_nameProduct
            // 
            this.txt_nameProduct.Location = new System.Drawing.Point(184, 81);
            this.txt_nameProduct.Name = "txt_nameProduct";
            this.txt_nameProduct.Size = new System.Drawing.Size(120, 20);
            this.txt_nameProduct.TabIndex = 6;
            // 
            // txt_prix
            // 
            this.txt_prix.Location = new System.Drawing.Point(184, 114);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(120, 20);
            this.txt_prix.TabIndex = 7;
            // 
            // num_quantite
            // 
            this.num_quantite.Location = new System.Drawing.Point(184, 149);
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
            this.num_quantite.Size = new System.Drawing.Size(120, 20);
            this.num_quantite.TabIndex = 8;
            this.num_quantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_alert
            // 
            this.num_alert.Location = new System.Drawing.Point(184, 183);
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
            this.num_alert.Size = new System.Drawing.Size(120, 20);
            this.num_alert.TabIndex = 9;
            this.num_alert.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbx_categorie
            // 
            this.cbx_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categorie.FormattingEnabled = true;
            this.cbx_categorie.Location = new System.Drawing.Point(183, 224);
            this.cbx_categorie.Name = "cbx_categorie";
            this.cbx_categorie.Size = new System.Drawing.Size(121, 21);
            this.cbx_categorie.TabIndex = 10;
            // 
            // cbx_fournisseur
            // 
            this.cbx_fournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_fournisseur.FormattingEnabled = true;
            this.cbx_fournisseur.Location = new System.Drawing.Point(183, 261);
            this.cbx_fournisseur.Name = "cbx_fournisseur";
            this.cbx_fournisseur.Size = new System.Drawing.Size(121, 21);
            this.cbx_fournisseur.TabIndex = 11;
            // 
            // bt_validateAjout
            // 
            this.bt_validateAjout.Location = new System.Drawing.Point(184, 314);
            this.bt_validateAjout.Name = "bt_validateAjout";
            this.bt_validateAjout.Size = new System.Drawing.Size(75, 23);
            this.bt_validateAjout.TabIndex = 12;
            this.bt_validateAjout.Text = "Valider";
            this.bt_validateAjout.UseVisualStyleBackColor = true;
            this.bt_validateAjout.Click += new System.EventHandler(this.bt_validateAjout_Click);
            // 
            // FrmAjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 382);
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
            this.Name = "FrmAjoutProduit";
            this.Text = "Ajout Produit";
            this.Load += new System.EventHandler(this.FrmAjoutProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_quantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_alert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nameProduct;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.NumericUpDown num_quantite;
        private System.Windows.Forms.NumericUpDown num_alert;
        private System.Windows.Forms.ComboBox cbx_categorie;
        private System.Windows.Forms.ComboBox cbx_fournisseur;
        private System.Windows.Forms.Button bt_validateAjout;
    }
}