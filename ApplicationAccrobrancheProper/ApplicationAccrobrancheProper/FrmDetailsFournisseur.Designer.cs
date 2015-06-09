namespace ApplicationAccrobrancheProper
{
    partial class FrmDetailsFournisseur
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cpFournisseurLabel;
            System.Windows.Forms.Label idFournisseurLabel;
            System.Windows.Forms.Label nomFournisseurLabel;
            System.Windows.Forms.Label villeFournisseurLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailsFournisseur));
            this.cpFournisseurTextBox = new System.Windows.Forms.TextBox();
            this.idFournisseurTextBox = new System.Windows.Forms.TextBox();
            this.nomFournisseurTextBox = new System.Windows.Forms.TextBox();
            this.villeFournisseurTextBox = new System.Windows.Forms.TextBox();
            this.nomProduitLabel1 = new System.Windows.Forms.Label();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            cpFournisseurLabel = new System.Windows.Forms.Label();
            idFournisseurLabel = new System.Windows.Forms.Label();
            nomFournisseurLabel = new System.Windows.Forms.Label();
            villeFournisseurLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // cpFournisseurLabel
            // 
            cpFournisseurLabel.AutoSize = true;
            cpFournisseurLabel.BackColor = System.Drawing.Color.Transparent;
            cpFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpFournisseurLabel.ForeColor = System.Drawing.Color.White;
            cpFournisseurLabel.Location = new System.Drawing.Point(10, 246);
            cpFournisseurLabel.Name = "cpFournisseurLabel";
            cpFournisseurLabel.Size = new System.Drawing.Size(154, 25);
            cpFournisseurLabel.TabIndex = 1;
            cpFournisseurLabel.Text = "Code Postal :";
            // 
            // idFournisseurLabel
            // 
            idFournisseurLabel.AutoSize = true;
            idFournisseurLabel.BackColor = System.Drawing.Color.Transparent;
            idFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            idFournisseurLabel.ForeColor = System.Drawing.Color.White;
            idFournisseurLabel.Location = new System.Drawing.Point(10, 114);
            idFournisseurLabel.Name = "idFournisseurLabel";
            idFournisseurLabel.Size = new System.Drawing.Size(187, 25);
            idFournisseurLabel.TabIndex = 3;
            idFournisseurLabel.Text = "Ref Fournisseur:";
            // 
            // nomFournisseurLabel
            // 
            nomFournisseurLabel.AutoSize = true;
            nomFournisseurLabel.BackColor = System.Drawing.Color.Transparent;
            nomFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            nomFournisseurLabel.ForeColor = System.Drawing.Color.White;
            nomFournisseurLabel.Location = new System.Drawing.Point(10, 156);
            nomFournisseurLabel.Name = "nomFournisseurLabel";
            nomFournisseurLabel.Size = new System.Drawing.Size(198, 25);
            nomFournisseurLabel.TabIndex = 5;
            nomFournisseurLabel.Text = "Nom Fournisseur:";
            // 
            // villeFournisseurLabel
            // 
            villeFournisseurLabel.AutoSize = true;
            villeFournisseurLabel.BackColor = System.Drawing.Color.Transparent;
            villeFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            villeFournisseurLabel.ForeColor = System.Drawing.Color.White;
            villeFournisseurLabel.Location = new System.Drawing.Point(10, 202);
            villeFournisseurLabel.Name = "villeFournisseurLabel";
            villeFournisseurLabel.Size = new System.Drawing.Size(197, 25);
            villeFournisseurLabel.TabIndex = 7;
            villeFournisseurLabel.Text = "Ville Fournisseur:";
            // 
            // cpFournisseurTextBox
            // 
            this.cpFournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeFournisseur.cpFournisseur", true));
            this.cpFournisseurTextBox.Enabled = false;
            this.cpFournisseurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpFournisseurTextBox.Location = new System.Drawing.Point(211, 245);
            this.cpFournisseurTextBox.Name = "cpFournisseurTextBox";
            this.cpFournisseurTextBox.Size = new System.Drawing.Size(107, 29);
            this.cpFournisseurTextBox.TabIndex = 2;
            // 
            // idFournisseurTextBox
            // 
            this.idFournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeFournisseur.idFournisseur", true));
            this.idFournisseurTextBox.Enabled = false;
            this.idFournisseurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFournisseurTextBox.Location = new System.Drawing.Point(211, 114);
            this.idFournisseurTextBox.Name = "idFournisseurTextBox";
            this.idFournisseurTextBox.Size = new System.Drawing.Size(35, 29);
            this.idFournisseurTextBox.TabIndex = 4;
            // 
            // nomFournisseurTextBox
            // 
            this.nomFournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeFournisseur.nomFournisseur", true));
            this.nomFournisseurTextBox.Enabled = false;
            this.nomFournisseurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomFournisseurTextBox.Location = new System.Drawing.Point(211, 155);
            this.nomFournisseurTextBox.Name = "nomFournisseurTextBox";
            this.nomFournisseurTextBox.Size = new System.Drawing.Size(228, 29);
            this.nomFournisseurTextBox.TabIndex = 6;
            // 
            // villeFournisseurTextBox
            // 
            this.villeFournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.villeFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeFournisseur.villeFournisseur", true));
            this.villeFournisseurTextBox.Enabled = false;
            this.villeFournisseurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeFournisseurTextBox.Location = new System.Drawing.Point(211, 201);
            this.villeFournisseurTextBox.Name = "villeFournisseurTextBox";
            this.villeFournisseurTextBox.Size = new System.Drawing.Size(228, 29);
            this.villeFournisseurTextBox.TabIndex = 8;
            // 
            // nomProduitLabel1
            // 
            this.nomProduitLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nomProduitLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "nomProduit", true));
            this.nomProduitLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomProduitLabel1.ForeColor = System.Drawing.Color.Red;
            this.nomProduitLabel1.Location = new System.Drawing.Point(12, 29);
            this.nomProduitLabel1.Name = "nomProduitLabel1";
            this.nomProduitLabel1.Size = new System.Drawing.Size(394, 41);
            this.nomProduitLabel1.TabIndex = 10;
            this.nomProduitLabel1.Text = "label2";
            this.nomProduitLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ApplicationAccrobrancheProper.Produit);
            // 
            // FrmDetailsFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(462, 325);
            this.Controls.Add(this.nomProduitLabel1);
            this.Controls.Add(cpFournisseurLabel);
            this.Controls.Add(this.cpFournisseurTextBox);
            this.Controls.Add(idFournisseurLabel);
            this.Controls.Add(this.idFournisseurTextBox);
            this.Controls.Add(nomFournisseurLabel);
            this.Controls.Add(this.nomFournisseurTextBox);
            this.Controls.Add(villeFournisseurLabel);
            this.Controls.Add(this.villeFournisseurTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetailsFournisseur";
            this.Text = "Fiche Fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.TextBox cpFournisseurTextBox;
        private System.Windows.Forms.TextBox idFournisseurTextBox;
        private System.Windows.Forms.TextBox nomFournisseurTextBox;
        private System.Windows.Forms.TextBox villeFournisseurTextBox;
        private System.Windows.Forms.Label nomProduitLabel1;

    }
}