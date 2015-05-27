namespace ApplicationAccrobrancheProper
{
    partial class FrmConfigs
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
            System.Windows.Forms.Label stockAlertLabel;
            System.Windows.Forms.Label quantiteStockProduitLabel;
            System.Windows.Forms.Label prixProduitHTLabel;
            System.Windows.Forms.Label nomProduitLabel;
            System.Windows.Forms.Label idProduitLabel;
            System.Windows.Forms.Label idFournisseurLabel;
            System.Windows.Forms.Label idCategorieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigs));
            this.bnProduits = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bsProduits = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.produitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stockAlertTextBox = new System.Windows.Forms.TextBox();
            this.quantiteStockProduitTextBox = new System.Windows.Forms.TextBox();
            this.prixProduitHTTextBox = new System.Windows.Forms.TextBox();
            this.nomProduitTextBox = new System.Windows.Forms.TextBox();
            this.idProduitTextBox = new System.Windows.Forms.TextBox();
            this.idFournisseurTextBox = new System.Windows.Forms.TextBox();
            this.idCategorieTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            stockAlertLabel = new System.Windows.Forms.Label();
            quantiteStockProduitLabel = new System.Windows.Forms.Label();
            prixProduitHTLabel = new System.Windows.Forms.Label();
            nomProduitLabel = new System.Windows.Forms.Label();
            idProduitLabel = new System.Windows.Forms.Label();
            idFournisseurLabel = new System.Windows.Forms.Label();
            idCategorieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnProduits)).BeginInit();
            this.bnProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduits)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockAlertLabel
            // 
            stockAlertLabel.AutoSize = true;
            stockAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockAlertLabel.Location = new System.Drawing.Point(56, 225);
            stockAlertLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stockAlertLabel.Name = "stockAlertLabel";
            stockAlertLabel.Size = new System.Drawing.Size(90, 20);
            stockAlertLabel.TabIndex = 18;
            stockAlertLabel.Text = "Seuil Alerte";
            // 
            // quantiteStockProduitLabel
            // 
            quantiteStockProduitLabel.AutoSize = true;
            quantiteStockProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantiteStockProduitLabel.Location = new System.Drawing.Point(56, 189);
            quantiteStockProduitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantiteStockProduitLabel.Name = "quantiteStockProduitLabel";
            quantiteStockProduitLabel.Size = new System.Drawing.Size(115, 20);
            quantiteStockProduitLabel.TabIndex = 16;
            quantiteStockProduitLabel.Text = "Quantite Stock";
            // 
            // prixProduitHTLabel
            // 
            prixProduitHTLabel.AutoSize = true;
            prixProduitHTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prixProduitHTLabel.Location = new System.Drawing.Point(56, 156);
            prixProduitHTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prixProduitHTLabel.Name = "prixProduitHTLabel";
            prixProduitHTLabel.Size = new System.Drawing.Size(63, 20);
            prixProduitHTLabel.TabIndex = 14;
            prixProduitHTLabel.Text = "Prix HT:";
            // 
            // nomProduitLabel
            // 
            nomProduitLabel.AutoSize = true;
            nomProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomProduitLabel.Location = new System.Drawing.Point(56, 29);
            nomProduitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomProduitLabel.Name = "nomProduitLabel";
            nomProduitLabel.Size = new System.Drawing.Size(96, 20);
            nomProduitLabel.TabIndex = 12;
            nomProduitLabel.Text = "Nom Produit";
            // 
            // idProduitLabel
            // 
            idProduitLabel.AutoSize = true;
            idProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProduitLabel.Location = new System.Drawing.Point(56, 124);
            idProduitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idProduitLabel.Name = "idProduitLabel";
            idProduitLabel.Size = new System.Drawing.Size(80, 20);
            idProduitLabel.TabIndex = 10;
            idProduitLabel.Text = "ID Produit";
            // 
            // idFournisseurLabel
            // 
            idFournisseurLabel.AutoSize = true;
            idFournisseurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idFournisseurLabel.Location = new System.Drawing.Point(56, 91);
            idFournisseurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idFournisseurLabel.Name = "idFournisseurLabel";
            idFournisseurLabel.Size = new System.Drawing.Size(114, 20);
            idFournisseurLabel.TabIndex = 8;
            idFournisseurLabel.Text = "ID Fournisseur";
            // 
            // idCategorieLabel
            // 
            idCategorieLabel.AutoSize = true;
            idCategorieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCategorieLabel.Location = new System.Drawing.Point(56, 61);
            idCategorieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idCategorieLabel.Name = "idCategorieLabel";
            idCategorieLabel.Size = new System.Drawing.Size(99, 20);
            idCategorieLabel.TabIndex = 6;
            idCategorieLabel.Text = "ID Catégorie";
            // 
            // bnProduits
            // 
            this.bnProduits.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnProduits.BindingSource = this.bsProduits;
            this.bnProduits.CountItem = this.bindingNavigatorCountItem;
            this.bnProduits.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnProduits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.produitBindingNavigatorSaveItem});
            this.bnProduits.Location = new System.Drawing.Point(0, 0);
            this.bnProduits.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnProduits.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnProduits.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnProduits.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnProduits.Name = "bnProduits";
            this.bnProduits.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnProduits.PositionItem = this.bindingNavigatorPositionItem;
            this.bnProduits.Size = new System.Drawing.Size(1916, 25);
            this.bnProduits.TabIndex = 5;
            this.bnProduits.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bsProduits
            // 
            this.bsProduits.DataSource = typeof(ApplicationAccrobrancheProper.Produit);
            this.bsProduits.CurrentChanged += new System.EventHandler(this.bsProduits_CurrentChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // produitBindingNavigatorSaveItem
            // 
            this.produitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produitBindingNavigatorSaveItem.Image")));
            this.produitBindingNavigatorSaveItem.Name = "produitBindingNavigatorSaveItem";
            this.produitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produitBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.produitBindingNavigatorSaveItem.Click += new System.EventHandler(this.produitBindingNavigatorSaveItem_Click);
            // 
            // stockAlertTextBox
            // 
            this.stockAlertTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduits, "StockAlert", true));
            this.stockAlertTextBox.Location = new System.Drawing.Point(237, 220);
            this.stockAlertTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stockAlertTextBox.Name = "stockAlertTextBox";
            this.stockAlertTextBox.Size = new System.Drawing.Size(148, 26);
            this.stockAlertTextBox.TabIndex = 19;
            // 
            // quantiteStockProduitTextBox
            // 
            this.quantiteStockProduitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduits, "quantiteStockProduit", true));
            this.quantiteStockProduitTextBox.Location = new System.Drawing.Point(237, 184);
            this.quantiteStockProduitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantiteStockProduitTextBox.Name = "quantiteStockProduitTextBox";
            this.quantiteStockProduitTextBox.Size = new System.Drawing.Size(148, 26);
            this.quantiteStockProduitTextBox.TabIndex = 17;
            // 
            // prixProduitHTTextBox
            // 
            this.prixProduitHTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduits, "prixProduitHT", true));
            this.prixProduitHTTextBox.Location = new System.Drawing.Point(237, 151);
            this.prixProduitHTTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prixProduitHTTextBox.Name = "prixProduitHTTextBox";
            this.prixProduitHTTextBox.Size = new System.Drawing.Size(148, 26);
            this.prixProduitHTTextBox.TabIndex = 15;
            // 
            // nomProduitTextBox
            // 
            this.nomProduitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduits, "nomProduit", true));
            this.nomProduitTextBox.Location = new System.Drawing.Point(237, 24);
            this.nomProduitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomProduitTextBox.Name = "nomProduitTextBox";
            this.nomProduitTextBox.Size = new System.Drawing.Size(148, 26);
            this.nomProduitTextBox.TabIndex = 13;
            // 
            // idProduitTextBox
            // 
            this.idProduitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduits, "idProduit", true));
            this.idProduitTextBox.Location = new System.Drawing.Point(237, 119);
            this.idProduitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idProduitTextBox.Name = "idProduitTextBox";
            this.idProduitTextBox.Size = new System.Drawing.Size(148, 26);
            this.idProduitTextBox.TabIndex = 11;
            // 
            // idFournisseurTextBox
            // 
            this.idFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduits, "idFournisseur", true));
            this.idFournisseurTextBox.Location = new System.Drawing.Point(237, 86);
            this.idFournisseurTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idFournisseurTextBox.Name = "idFournisseurTextBox";
            this.idFournisseurTextBox.Size = new System.Drawing.Size(148, 26);
            this.idFournisseurTextBox.TabIndex = 9;
            // 
            // idCategorieTextBox
            // 
            this.idCategorieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduits, "idCategorie", true));
            this.idCategorieTextBox.Location = new System.Drawing.Point(237, 56);
            this.idCategorieTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idCategorieTextBox.Name = "idCategorieTextBox";
            this.idCategorieTextBox.Size = new System.Drawing.Size(148, 26);
            this.idCategorieTextBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idCategorieLabel);
            this.panel1.Controls.Add(this.idCategorieTextBox);
            this.panel1.Controls.Add(idProduitLabel);
            this.panel1.Controls.Add(this.idProduitTextBox);
            this.panel1.Controls.Add(idFournisseurLabel);
            this.panel1.Controls.Add(nomProduitLabel);
            this.panel1.Controls.Add(this.nomProduitTextBox);
            this.panel1.Controls.Add(this.idFournisseurTextBox);
            this.panel1.Controls.Add(prixProduitHTLabel);
            this.panel1.Controls.Add(this.prixProduitHTTextBox);
            this.panel1.Controls.Add(quantiteStockProduitLabel);
            this.panel1.Controls.Add(this.quantiteStockProduitTextBox);
            this.panel1.Controls.Add(stockAlertLabel);
            this.panel1.Controls.Add(this.stockAlertTextBox);
            this.panel1.Location = new System.Drawing.Point(13, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 275);
            this.panel1.TabIndex = 4;
            // 
            // FrmConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1916, 1020);
            this.Controls.Add(this.bnProduits);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConfigs";
            this.Text = "Réglages Logiciel";
            this.Load += new System.EventHandler(this.FrmConfigs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnProduits)).EndInit();
            this.bnProduits.ResumeLayout(false);
            this.bnProduits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduits)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsProduits;
        private System.Windows.Forms.BindingNavigator bnProduits;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton produitBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stockAlertTextBox;
        private System.Windows.Forms.TextBox quantiteStockProduitTextBox;
        private System.Windows.Forms.TextBox prixProduitHTTextBox;
        private System.Windows.Forms.TextBox nomProduitTextBox;
        private System.Windows.Forms.TextBox idProduitTextBox;
        private System.Windows.Forms.TextBox idFournisseurTextBox;
        private System.Windows.Forms.TextBox idCategorieTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}