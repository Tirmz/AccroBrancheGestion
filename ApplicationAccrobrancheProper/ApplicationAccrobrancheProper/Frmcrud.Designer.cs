namespace ApplicationAccrobrancheProper
{
    partial class Frmcrud
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
            this.tabCrud = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_updateProduct = new System.Windows.Forms.Button();
            this.bt_deleteProduct = new System.Windows.Forms.Button();
            this.bt_addProduct = new System.Windows.Forms.Button();
            this.dg_products = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_addCategorie = new System.Windows.Forms.Button();
            this.bt_updateCategorie = new System.Windows.Forms.Button();
            this.bt_deleteCategorie = new System.Windows.Forms.Button();
            this.dg_categories = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dg_fournisseur = new System.Windows.Forms.DataGridView();
            this.bt_deleteFournisseur = new System.Windows.Forms.Button();
            this.bt_updateFournissseur = new System.Windows.Forms.Button();
            this.bt_addFournissseur = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCategorie = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFournisseur = new System.Windows.Forms.BindingSource(this.components);
            this.tabCrud.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_categories)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_fournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCrud
            // 
            this.tabCrud.Controls.Add(this.tabPage1);
            this.tabCrud.Controls.Add(this.tabPage2);
            this.tabCrud.Controls.Add(this.tabPage3);
            this.tabCrud.Location = new System.Drawing.Point(2, 1);
            this.tabCrud.Name = "tabCrud";
            this.tabCrud.SelectedIndex = 0;
            this.tabCrud.Size = new System.Drawing.Size(1187, 571);
            this.tabCrud.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_updateProduct);
            this.tabPage1.Controls.Add(this.bt_deleteProduct);
            this.tabPage1.Controls.Add(this.bt_addProduct);
            this.tabPage1.Controls.Add(this.dg_products);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1179, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_updateProduct
            // 
            this.bt_updateProduct.Location = new System.Drawing.Point(544, 494);
            this.bt_updateProduct.Name = "bt_updateProduct";
            this.bt_updateProduct.Size = new System.Drawing.Size(122, 45);
            this.bt_updateProduct.TabIndex = 2;
            this.bt_updateProduct.Text = "Modifier";
            this.bt_updateProduct.UseVisualStyleBackColor = true;
            this.bt_updateProduct.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_deleteProduct
            // 
            this.bt_deleteProduct.Location = new System.Drawing.Point(416, 495);
            this.bt_deleteProduct.Name = "bt_deleteProduct";
            this.bt_deleteProduct.Size = new System.Drawing.Size(122, 45);
            this.bt_deleteProduct.TabIndex = 3;
            this.bt_deleteProduct.Text = "Supprimer";
            this.bt_deleteProduct.UseVisualStyleBackColor = true;
            this.bt_deleteProduct.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_addProduct
            // 
            this.bt_addProduct.Location = new System.Drawing.Point(672, 494);
            this.bt_addProduct.Name = "bt_addProduct";
            this.bt_addProduct.Size = new System.Drawing.Size(122, 45);
            this.bt_addProduct.TabIndex = 1;
            this.bt_addProduct.Text = "Ajouter";
            this.bt_addProduct.UseVisualStyleBackColor = true;
            this.bt_addProduct.Click += new System.EventHandler(this.bt_addProduct_Click);
            // 
            // dg_products
            // 
            this.dg_products.AutoGenerateColumns = false;
            this.dg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dg_products.DataSource = this.bs;
            this.dg_products.Location = new System.Drawing.Point(3, 0);
            this.dg_products.Name = "dg_products";
            this.dg_products.Size = new System.Drawing.Size(1025, 455);
            this.dg_products.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_addCategorie);
            this.tabPage2.Controls.Add(this.bt_updateCategorie);
            this.tabPage2.Controls.Add(this.bt_deleteCategorie);
            this.tabPage2.Controls.Add(this.dg_categories);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1179, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_addCategorie
            // 
            this.bt_addCategorie.Location = new System.Drawing.Point(443, 494);
            this.bt_addCategorie.Name = "bt_addCategorie";
            this.bt_addCategorie.Size = new System.Drawing.Size(122, 45);
            this.bt_addCategorie.TabIndex = 3;
            this.bt_addCategorie.Text = "Ajouter";
            this.bt_addCategorie.UseVisualStyleBackColor = true;
            this.bt_addCategorie.Click += new System.EventHandler(this.bt_addCategorie_Click);
            // 
            // bt_updateCategorie
            // 
            this.bt_updateCategorie.Location = new System.Drawing.Point(315, 494);
            this.bt_updateCategorie.Name = "bt_updateCategorie";
            this.bt_updateCategorie.Size = new System.Drawing.Size(122, 45);
            this.bt_updateCategorie.TabIndex = 2;
            this.bt_updateCategorie.Text = "Modifier";
            this.bt_updateCategorie.UseVisualStyleBackColor = true;
            this.bt_updateCategorie.Click += new System.EventHandler(this.bt_updateCategorie_Click);
            // 
            // bt_deleteCategorie
            // 
            this.bt_deleteCategorie.Location = new System.Drawing.Point(187, 494);
            this.bt_deleteCategorie.Name = "bt_deleteCategorie";
            this.bt_deleteCategorie.Size = new System.Drawing.Size(122, 45);
            this.bt_deleteCategorie.TabIndex = 1;
            this.bt_deleteCategorie.Text = "Supprimer";
            this.bt_deleteCategorie.UseVisualStyleBackColor = true;
            this.bt_deleteCategorie.Click += new System.EventHandler(this.bt_deleteCategorie_Click);
            // 
            // dg_categories
            // 
            this.dg_categories.AutoGenerateColumns = false;
            this.dg_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dg_categories.DataSource = this.bsCategorie;
            this.dg_categories.Location = new System.Drawing.Point(28, 72);
            this.dg_categories.Name = "dg_categories";
            this.dg_categories.Size = new System.Drawing.Size(271, 220);
            this.dg_categories.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bt_addFournissseur);
            this.tabPage3.Controls.Add(this.bt_updateFournissseur);
            this.tabPage3.Controls.Add(this.bt_deleteFournisseur);
            this.tabPage3.Controls.Add(this.dg_fournisseur);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1179, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dg_fournisseur
            // 
            this.dg_fournisseur.AutoGenerateColumns = false;
            this.dg_fournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_fournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dg_fournisseur.DataSource = this.bsFournisseur;
            this.dg_fournisseur.Location = new System.Drawing.Point(6, 84);
            this.dg_fournisseur.Name = "dg_fournisseur";
            this.dg_fournisseur.Size = new System.Drawing.Size(519, 220);
            this.dg_fournisseur.TabIndex = 0;
            // 
            // bt_deleteFournisseur
            // 
            this.bt_deleteFournisseur.Location = new System.Drawing.Point(320, 494);
            this.bt_deleteFournisseur.Name = "bt_deleteFournisseur";
            this.bt_deleteFournisseur.Size = new System.Drawing.Size(122, 45);
            this.bt_deleteFournisseur.TabIndex = 1;
            this.bt_deleteFournisseur.Text = "Supprimer";
            this.bt_deleteFournisseur.UseVisualStyleBackColor = true;
            this.bt_deleteFournisseur.Click += new System.EventHandler(this.bt_deleteFournisseur_Click);
            // 
            // bt_updateFournissseur
            // 
            this.bt_updateFournissseur.Location = new System.Drawing.Point(448, 494);
            this.bt_updateFournissseur.Name = "bt_updateFournissseur";
            this.bt_updateFournissseur.Size = new System.Drawing.Size(122, 45);
            this.bt_updateFournissseur.TabIndex = 2;
            this.bt_updateFournissseur.Text = "Modifier";
            this.bt_updateFournissseur.UseVisualStyleBackColor = true;
            this.bt_updateFournissseur.Click += new System.EventHandler(this.bt_updateFournissseur_Click);
            // 
            // bt_addFournissseur
            // 
            this.bt_addFournissseur.Location = new System.Drawing.Point(574, 493);
            this.bt_addFournissseur.Name = "bt_addFournissseur";
            this.bt_addFournissseur.Size = new System.Drawing.Size(122, 45);
            this.bt_addFournissseur.TabIndex = 3;
            this.bt_addFournissseur.Text = "Ajouter";
            this.bt_addFournissseur.UseVisualStyleBackColor = true;
            this.bt_addFournissseur.Click += new System.EventHandler(this.bt_addFournissseur_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProduit";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProduit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomProduit";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomProduit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prixProduitHT";
            this.dataGridViewTextBoxColumn3.HeaderText = "prixProduitHT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantiteStockProduit";
            this.dataGridViewTextBoxColumn4.HeaderText = "quantiteStockProduit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StockAlert";
            this.dataGridViewTextBoxColumn5.HeaderText = "StockAlert";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idCategorie";
            this.dataGridViewTextBoxColumn6.HeaderText = "idCategorie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idFournisseur";
            this.dataGridViewTextBoxColumn7.HeaderText = "idFournisseur";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LaCategorie";
            this.dataGridViewTextBoxColumn8.HeaderText = "LaCategorie";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LeFournisseur";
            this.dataGridViewTextBoxColumn9.HeaderText = "LeFournisseur";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GetCategorie";
            this.dataGridViewTextBoxColumn10.HeaderText = "GetCategorie";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "GetFournisseur";
            this.dataGridViewTextBoxColumn11.HeaderText = "GetFournisseur";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "GetPrixTCC";
            this.dataGridViewTextBoxColumn12.HeaderText = "GetPrixTCC";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ApplicationAccrobrancheProper.Produit);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "idCategorie";
            this.dataGridViewTextBoxColumn13.HeaderText = "idCategorie";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "libelleCategorie";
            this.dataGridViewTextBoxColumn14.HeaderText = "libelleCategorie";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // bsCategorie
            // 
            this.bsCategorie.DataSource = typeof(ApplicationAccrobrancheProper.Categorie);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "idFournisseur";
            this.dataGridViewTextBoxColumn15.HeaderText = "idFournisseur";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "nomFournisseur";
            this.dataGridViewTextBoxColumn16.HeaderText = "nomFournisseur";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "villeFournisseur";
            this.dataGridViewTextBoxColumn17.HeaderText = "villeFournisseur";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "cpFournisseur";
            this.dataGridViewTextBoxColumn18.HeaderText = "cpFournisseur";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // bsFournisseur
            // 
            this.bsFournisseur.DataSource = typeof(ApplicationAccrobrancheProper.Fournisseur);
            // 
            // Frmcrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 575);
            this.Controls.Add(this.tabCrud);
            this.Name = "Frmcrud";
            this.Text = "Frmcrud";
            this.Load += new System.EventHandler(this.Frmcrud_Load);
            this.tabCrud.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_categories)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_fournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFournisseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCrud;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dg_products;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView dg_categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.BindingSource bsCategorie;
        private System.Windows.Forms.DataGridView dg_fournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.BindingSource bsFournisseur;
        private System.Windows.Forms.Button bt_addProduct;
        private System.Windows.Forms.Button bt_updateProduct;
        private System.Windows.Forms.Button bt_deleteProduct;
        private System.Windows.Forms.Button bt_addCategorie;
        private System.Windows.Forms.Button bt_updateCategorie;
        private System.Windows.Forms.Button bt_deleteCategorie;
        private System.Windows.Forms.Button bt_addFournissseur;
        private System.Windows.Forms.Button bt_updateFournissseur;
        private System.Windows.Forms.Button bt_deleteFournisseur;



    }
}