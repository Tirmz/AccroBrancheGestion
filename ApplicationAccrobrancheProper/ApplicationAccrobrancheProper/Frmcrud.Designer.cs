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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcrud));
            this.tabCrud = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_deleteProduct = new System.Windows.Forms.Button();
            this.bt_addProduct = new System.Windows.Forms.Button();
            this.bt_updateProduct = new System.Windows.Forms.Button();
            this.dg_products = new System.Windows.Forms.DataGridView();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_deleteCategorie = new System.Windows.Forms.Button();
            this.bt_addCategorie = new System.Windows.Forms.Button();
            this.bt_updateCategorie = new System.Windows.Forms.Button();
            this.dg_categories = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCategorie = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_deleteFournisseur = new System.Windows.Forms.Button();
            this.bt_addFournissseur = new System.Windows.Forms.Button();
            this.bt_updateFournissseur = new System.Windows.Forms.Button();
            this.dg_fournisseur = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFournisseur = new System.Windows.Forms.BindingSource(this.components);
            this.tabCrud.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategorie)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_fournisseur)).BeginInit();
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
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dg_products);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1179, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_deleteProduct);
            this.groupBox1.Controls.Add(this.bt_addProduct);
            this.groupBox1.Controls.Add(this.bt_updateProduct);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(355, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // bt_deleteProduct
            // 
            this.bt_deleteProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_deleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deleteProduct.ForeColor = System.Drawing.Color.White;
            this.bt_deleteProduct.Location = new System.Drawing.Point(110, 14);
            this.bt_deleteProduct.Name = "bt_deleteProduct";
            this.bt_deleteProduct.Size = new System.Drawing.Size(122, 45);
            this.bt_deleteProduct.TabIndex = 3;
            this.bt_deleteProduct.Text = "Supprimer";
            this.bt_deleteProduct.UseVisualStyleBackColor = false;
            this.bt_deleteProduct.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_addProduct
            // 
            this.bt_addProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_addProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addProduct.ForeColor = System.Drawing.Color.White;
            this.bt_addProduct.Location = new System.Drawing.Point(366, 14);
            this.bt_addProduct.Name = "bt_addProduct";
            this.bt_addProduct.Size = new System.Drawing.Size(122, 45);
            this.bt_addProduct.TabIndex = 1;
            this.bt_addProduct.Text = "Ajouter";
            this.bt_addProduct.UseVisualStyleBackColor = false;
            this.bt_addProduct.Click += new System.EventHandler(this.bt_addProduct_Click);
            // 
            // bt_updateProduct
            // 
            this.bt_updateProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_updateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_updateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_updateProduct.ForeColor = System.Drawing.Color.White;
            this.bt_updateProduct.Location = new System.Drawing.Point(238, 14);
            this.bt_updateProduct.Name = "bt_updateProduct";
            this.bt_updateProduct.Size = new System.Drawing.Size(122, 45);
            this.bt_updateProduct.TabIndex = 2;
            this.bt_updateProduct.Text = "Modifier";
            this.bt_updateProduct.UseVisualStyleBackColor = false;
            this.bt_updateProduct.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // dg_products
            // 
            this.dg_products.AutoGenerateColumns = false;
            this.dg_products.BackgroundColor = System.Drawing.Color.Teal;
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
            this.dg_products.Location = new System.Drawing.Point(85, 0);
            this.dg_products.Name = "dg_products";
            this.dg_products.Size = new System.Drawing.Size(1025, 455);
            this.dg_products.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProduit";
            this.dataGridViewTextBoxColumn1.HeaderText = "Référence";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomProduit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prixProduitHT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix HT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantiteStockProduit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantité Stock";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StockAlert";
            this.dataGridViewTextBoxColumn5.HeaderText = "Seuil Alerte";
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
            this.dataGridViewTextBoxColumn10.HeaderText = "Catégorie";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "GetFournisseur";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fournisseur";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "GetPrixTCC";
            this.dataGridViewTextBoxColumn12.HeaderText = "Prix TTC";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ApplicationAccrobrancheProper.Produit);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dg_categories);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1179, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_deleteCategorie);
            this.groupBox2.Controls.Add(this.bt_addCategorie);
            this.groupBox2.Controls.Add(this.bt_updateCategorie);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(359, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // bt_deleteCategorie
            // 
            this.bt_deleteCategorie.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_deleteCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_deleteCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deleteCategorie.ForeColor = System.Drawing.Color.White;
            this.bt_deleteCategorie.Location = new System.Drawing.Point(69, 25);
            this.bt_deleteCategorie.Name = "bt_deleteCategorie";
            this.bt_deleteCategorie.Size = new System.Drawing.Size(122, 45);
            this.bt_deleteCategorie.TabIndex = 1;
            this.bt_deleteCategorie.Text = "Supprimer";
            this.bt_deleteCategorie.UseVisualStyleBackColor = false;
            this.bt_deleteCategorie.Click += new System.EventHandler(this.bt_deleteCategorie_Click);
            // 
            // bt_addCategorie
            // 
            this.bt_addCategorie.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_addCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addCategorie.ForeColor = System.Drawing.Color.White;
            this.bt_addCategorie.Location = new System.Drawing.Point(325, 25);
            this.bt_addCategorie.Name = "bt_addCategorie";
            this.bt_addCategorie.Size = new System.Drawing.Size(122, 45);
            this.bt_addCategorie.TabIndex = 3;
            this.bt_addCategorie.Text = "Ajouter";
            this.bt_addCategorie.UseVisualStyleBackColor = false;
            this.bt_addCategorie.Click += new System.EventHandler(this.bt_addCategorie_Click);
            // 
            // bt_updateCategorie
            // 
            this.bt_updateCategorie.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_updateCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_updateCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_updateCategorie.ForeColor = System.Drawing.Color.White;
            this.bt_updateCategorie.Location = new System.Drawing.Point(197, 25);
            this.bt_updateCategorie.Name = "bt_updateCategorie";
            this.bt_updateCategorie.Size = new System.Drawing.Size(122, 45);
            this.bt_updateCategorie.TabIndex = 2;
            this.bt_updateCategorie.Text = "Modifier";
            this.bt_updateCategorie.UseVisualStyleBackColor = false;
            this.bt_updateCategorie.Click += new System.EventHandler(this.bt_updateCategorie_Click);
            // 
            // dg_categories
            // 
            this.dg_categories.AutoGenerateColumns = false;
            this.dg_categories.BackgroundColor = System.Drawing.Color.Teal;
            this.dg_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dg_categories.DataSource = this.bsCategorie;
            this.dg_categories.Location = new System.Drawing.Point(421, 81);
            this.dg_categories.Name = "dg_categories";
            this.dg_categories.Size = new System.Drawing.Size(335, 220);
            this.dg_categories.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "idCategorie";
            this.dataGridViewTextBoxColumn13.HeaderText = "Référence";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "libelleCategorie";
            this.dataGridViewTextBoxColumn14.HeaderText = "Libellé";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // bsCategorie
            // 
            this.bsCategorie.DataSource = typeof(ApplicationAccrobrancheProper.Categorie);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Teal;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dg_fournisseur);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1179, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_deleteFournisseur);
            this.groupBox3.Controls.Add(this.bt_addFournissseur);
            this.groupBox3.Controls.Add(this.bt_updateFournissseur);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(340, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 82);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // bt_deleteFournisseur
            // 
            this.bt_deleteFournisseur.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_deleteFournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_deleteFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deleteFournisseur.ForeColor = System.Drawing.Color.White;
            this.bt_deleteFournisseur.Location = new System.Drawing.Point(45, 25);
            this.bt_deleteFournisseur.Name = "bt_deleteFournisseur";
            this.bt_deleteFournisseur.Size = new System.Drawing.Size(122, 45);
            this.bt_deleteFournisseur.TabIndex = 1;
            this.bt_deleteFournisseur.Text = "Supprimer";
            this.bt_deleteFournisseur.UseVisualStyleBackColor = false;
            this.bt_deleteFournisseur.Click += new System.EventHandler(this.bt_deleteFournisseur_Click);
            // 
            // bt_addFournissseur
            // 
            this.bt_addFournissseur.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_addFournissseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addFournissseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addFournissseur.ForeColor = System.Drawing.Color.White;
            this.bt_addFournissseur.Location = new System.Drawing.Point(299, 24);
            this.bt_addFournissseur.Name = "bt_addFournissseur";
            this.bt_addFournissseur.Size = new System.Drawing.Size(122, 45);
            this.bt_addFournissseur.TabIndex = 3;
            this.bt_addFournissseur.Text = "Ajouter";
            this.bt_addFournissseur.UseVisualStyleBackColor = false;
            this.bt_addFournissseur.Click += new System.EventHandler(this.bt_addFournissseur_Click);
            // 
            // bt_updateFournissseur
            // 
            this.bt_updateFournissseur.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_updateFournissseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_updateFournissseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_updateFournissseur.ForeColor = System.Drawing.Color.White;
            this.bt_updateFournissseur.Location = new System.Drawing.Point(173, 25);
            this.bt_updateFournissseur.Name = "bt_updateFournissseur";
            this.bt_updateFournissseur.Size = new System.Drawing.Size(122, 45);
            this.bt_updateFournissseur.TabIndex = 2;
            this.bt_updateFournissseur.Text = "Modifier";
            this.bt_updateFournissseur.UseVisualStyleBackColor = false;
            this.bt_updateFournissseur.Click += new System.EventHandler(this.bt_updateFournissseur_Click);
            // 
            // dg_fournisseur
            // 
            this.dg_fournisseur.AutoGenerateColumns = false;
            this.dg_fournisseur.BackgroundColor = System.Drawing.Color.Teal;
            this.dg_fournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_fournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dg_fournisseur.DataSource = this.bsFournisseur;
            this.dg_fournisseur.Location = new System.Drawing.Point(255, 96);
            this.dg_fournisseur.Name = "dg_fournisseur";
            this.dg_fournisseur.Size = new System.Drawing.Size(603, 220);
            this.dg_fournisseur.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "idFournisseur";
            this.dataGridViewTextBoxColumn15.HeaderText = "Référence";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "nomFournisseur";
            this.dataGridViewTextBoxColumn16.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "villeFournisseur";
            this.dataGridViewTextBoxColumn17.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 130;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "cpFournisseur";
            this.dataGridViewTextBoxColumn18.HeaderText = "Code Postal";
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
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1188, 575);
            this.Controls.Add(this.tabCrud);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcrud";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Frmcrud_Load);
            this.tabCrud.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategorie)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_fournisseur)).EndInit();
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
        private System.Windows.Forms.DataGridView dg_categories;
        private System.Windows.Forms.BindingSource bsCategorie;
        private System.Windows.Forms.DataGridView dg_fournisseur;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;



    }
}