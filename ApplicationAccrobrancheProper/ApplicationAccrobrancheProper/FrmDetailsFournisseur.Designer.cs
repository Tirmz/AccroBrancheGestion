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
            cpFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpFournisseurLabel.Location = new System.Drawing.Point(10, 246);
            cpFournisseurLabel.Name = "cpFournisseurLabel";
            cpFournisseurLabel.Size = new System.Drawing.Size(154, 25);
            cpFournisseurLabel.TabIndex = 1;
            cpFournisseurLabel.Text = "Code Postal :";
            // 
            // idFournisseurLabel
            // 
            idFournisseurLabel.AutoSize = true;
            idFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            idFournisseurLabel.Location = new System.Drawing.Point(10, 114);
            idFournisseurLabel.Name = "idFournisseurLabel";
            idFournisseurLabel.Size = new System.Drawing.Size(187, 25);
            idFournisseurLabel.TabIndex = 3;
            idFournisseurLabel.Text = "Ref Fournisseur:";
            // 
            // nomFournisseurLabel
            // 
            nomFournisseurLabel.AutoSize = true;
            nomFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            nomFournisseurLabel.Location = new System.Drawing.Point(10, 156);
            nomFournisseurLabel.Name = "nomFournisseurLabel";
            nomFournisseurLabel.Size = new System.Drawing.Size(195, 25);
            nomFournisseurLabel.TabIndex = 5;
            nomFournisseurLabel.Text = "nom Fournisseur:";
            // 
            // villeFournisseurLabel
            // 
            villeFournisseurLabel.AutoSize = true;
            villeFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            villeFournisseurLabel.Location = new System.Drawing.Point(10, 202);
            villeFournisseurLabel.Name = "villeFournisseurLabel";
            villeFournisseurLabel.Size = new System.Drawing.Size(194, 25);
            villeFournisseurLabel.TabIndex = 7;
            villeFournisseurLabel.Text = "ville Fournisseur:";
            // 
            // cpFournisseurTextBox
            // 
            this.cpFournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeFournisseur.cpFournisseur", true));
            this.cpFournisseurTextBox.Enabled = false;
            this.cpFournisseurTextBox.Location = new System.Drawing.Point(211, 251);
            this.cpFournisseurTextBox.Name = "cpFournisseurTextBox";
            this.cpFournisseurTextBox.Size = new System.Drawing.Size(61, 20);
            this.cpFournisseurTextBox.TabIndex = 2;
            // 
            // idFournisseurTextBox
            // 
            this.idFournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeFournisseur.idFournisseur", true));
            this.idFournisseurTextBox.Enabled = false;
            this.idFournisseurTextBox.Location = new System.Drawing.Point(211, 119);
            this.idFournisseurTextBox.Name = "idFournisseurTextBox";
            this.idFournisseurTextBox.Size = new System.Drawing.Size(26, 20);
            this.idFournisseurTextBox.TabIndex = 4;
            // 
            // nomFournisseurTextBox
            // 
            this.nomFournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeFournisseur.nomFournisseur", true));
            this.nomFournisseurTextBox.Enabled = false;
            this.nomFournisseurTextBox.Location = new System.Drawing.Point(211, 161);
            this.nomFournisseurTextBox.Name = "nomFournisseurTextBox";
            this.nomFournisseurTextBox.Size = new System.Drawing.Size(195, 20);
            this.nomFournisseurTextBox.TabIndex = 6;
            // 
            // villeFournisseurTextBox
            // 
            this.villeFournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.villeFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeFournisseur.villeFournisseur", true));
            this.villeFournisseurTextBox.Enabled = false;
            this.villeFournisseurTextBox.Location = new System.Drawing.Point(211, 209);
            this.villeFournisseurTextBox.Name = "villeFournisseurTextBox";
            this.villeFournisseurTextBox.Size = new System.Drawing.Size(195, 20);
            this.villeFournisseurTextBox.TabIndex = 8;
            // 
            // nomProduitLabel1
            // 
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
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 371);
            this.Controls.Add(this.nomProduitLabel1);
            this.Controls.Add(cpFournisseurLabel);
            this.Controls.Add(this.cpFournisseurTextBox);
            this.Controls.Add(idFournisseurLabel);
            this.Controls.Add(this.idFournisseurTextBox);
            this.Controls.Add(nomFournisseurLabel);
            this.Controls.Add(this.nomFournisseurTextBox);
            this.Controls.Add(villeFournisseurLabel);
            this.Controls.Add(this.villeFournisseurTextBox);
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