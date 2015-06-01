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
            System.Windows.Forms.Label idCategorieLabel;
            System.Windows.Forms.Label idFournisseurLabel;
            System.Windows.Forms.Label nomProduitLabel;
            System.Windows.Forms.Label prixProduitHTLabel;
            System.Windows.Forms.Label quantiteStockProduitLabel;
            System.Windows.Forms.Label stockAlertLabel;
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.produitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCategorieComboBox = new System.Windows.Forms.ComboBox();
            this.idFournisseurComboBox = new System.Windows.Forms.ComboBox();
            this.nomProduitTextBox = new System.Windows.Forms.TextBox();
            this.prixProduitHTTextBox = new System.Windows.Forms.TextBox();
            this.quantiteStockProduitTextBox = new System.Windows.Forms.TextBox();
            this.stockAlertTextBox = new System.Windows.Forms.TextBox();
            idCategorieLabel = new System.Windows.Forms.Label();
            idFournisseurLabel = new System.Windows.Forms.Label();
            nomProduitLabel = new System.Windows.Forms.Label();
            prixProduitHTLabel = new System.Windows.Forms.Label();
            quantiteStockProduitLabel = new System.Windows.Forms.Label();
            stockAlertLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingNavigator)).BeginInit();
            this.produitBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(ApplicationAccrobrancheProper.Produit);
            // 
            // produitBindingNavigator
            // 
            this.produitBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produitBindingNavigator.BindingSource = this.produitBindingSource;
            this.produitBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produitBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produitBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produitBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produitBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produitBindingNavigator.Name = "produitBindingNavigator";
            this.produitBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produitBindingNavigator.Size = new System.Drawing.Size(934, 25);
            this.produitBindingNavigator.TabIndex = 0;
            this.produitBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // produitBindingNavigatorSaveItem
            // 
            this.produitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produitBindingNavigatorSaveItem.Enabled = false;
            this.produitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produitBindingNavigatorSaveItem.Image")));
            this.produitBindingNavigatorSaveItem.Name = "produitBindingNavigatorSaveItem";
            this.produitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produitBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // idCategorieLabel
            // 
            idCategorieLabel.AutoSize = true;
            idCategorieLabel.Location = new System.Drawing.Point(136, 173);
            idCategorieLabel.Name = "idCategorieLabel";
            idCategorieLabel.Size = new System.Drawing.Size(66, 13);
            idCategorieLabel.TabIndex = 1;
            idCategorieLabel.Text = "id Categorie:";
            // 
            // idCategorieComboBox
            // 
            this.idCategorieComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "idCategorie", true));
            this.idCategorieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCategorieComboBox.FormattingEnabled = true;
            this.idCategorieComboBox.Location = new System.Drawing.Point(257, 170);
            this.idCategorieComboBox.Name = "idCategorieComboBox";
            this.idCategorieComboBox.Size = new System.Drawing.Size(121, 21);
            this.idCategorieComboBox.TabIndex = 2;
            // 
            // idFournisseurLabel
            // 
            idFournisseurLabel.AutoSize = true;
            idFournisseurLabel.Location = new System.Drawing.Point(136, 200);
            idFournisseurLabel.Name = "idFournisseurLabel";
            idFournisseurLabel.Size = new System.Drawing.Size(75, 13);
            idFournisseurLabel.TabIndex = 3;
            idFournisseurLabel.Text = "id Fournisseur:";
            // 
            // idFournisseurComboBox
            // 
            this.idFournisseurComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "idFournisseur", true));
            this.idFournisseurComboBox.FormattingEnabled = true;
            this.idFournisseurComboBox.Location = new System.Drawing.Point(257, 197);
            this.idFournisseurComboBox.Name = "idFournisseurComboBox";
            this.idFournisseurComboBox.Size = new System.Drawing.Size(121, 21);
            this.idFournisseurComboBox.TabIndex = 4;
            // 
            // nomProduitLabel
            // 
            nomProduitLabel.AutoSize = true;
            nomProduitLabel.Location = new System.Drawing.Point(136, 227);
            nomProduitLabel.Name = "nomProduitLabel";
            nomProduitLabel.Size = new System.Drawing.Size(66, 13);
            nomProduitLabel.TabIndex = 5;
            nomProduitLabel.Text = "nom Produit:";
            // 
            // nomProduitTextBox
            // 
            this.nomProduitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "nomProduit", true));
            this.nomProduitTextBox.Location = new System.Drawing.Point(257, 224);
            this.nomProduitTextBox.Name = "nomProduitTextBox";
            this.nomProduitTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomProduitTextBox.TabIndex = 6;
            // 
            // prixProduitHTLabel
            // 
            prixProduitHTLabel.AutoSize = true;
            prixProduitHTLabel.Location = new System.Drawing.Point(136, 253);
            prixProduitHTLabel.Name = "prixProduitHTLabel";
            prixProduitHTLabel.Size = new System.Drawing.Size(80, 13);
            prixProduitHTLabel.TabIndex = 7;
            prixProduitHTLabel.Text = "prix Produit HT:";
            // 
            // prixProduitHTTextBox
            // 
            this.prixProduitHTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixProduitHT", true));
            this.prixProduitHTTextBox.Location = new System.Drawing.Point(257, 250);
            this.prixProduitHTTextBox.Name = "prixProduitHTTextBox";
            this.prixProduitHTTextBox.Size = new System.Drawing.Size(121, 20);
            this.prixProduitHTTextBox.TabIndex = 8;
            // 
            // quantiteStockProduitLabel
            // 
            quantiteStockProduitLabel.AutoSize = true;
            quantiteStockProduitLabel.Location = new System.Drawing.Point(136, 279);
            quantiteStockProduitLabel.Name = "quantiteStockProduitLabel";
            quantiteStockProduitLabel.Size = new System.Drawing.Size(115, 13);
            quantiteStockProduitLabel.TabIndex = 9;
            quantiteStockProduitLabel.Text = "quantite Stock Produit:";
            // 
            // quantiteStockProduitTextBox
            // 
            this.quantiteStockProduitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "quantiteStockProduit", true));
            this.quantiteStockProduitTextBox.Location = new System.Drawing.Point(257, 276);
            this.quantiteStockProduitTextBox.Name = "quantiteStockProduitTextBox";
            this.quantiteStockProduitTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantiteStockProduitTextBox.TabIndex = 10;
            // 
            // stockAlertLabel
            // 
            stockAlertLabel.AutoSize = true;
            stockAlertLabel.Location = new System.Drawing.Point(136, 305);
            stockAlertLabel.Name = "stockAlertLabel";
            stockAlertLabel.Size = new System.Drawing.Size(62, 13);
            stockAlertLabel.TabIndex = 11;
            stockAlertLabel.Text = "Stock Alert:";
            // 
            // stockAlertTextBox
            // 
            this.stockAlertTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "StockAlert", true));
            this.stockAlertTextBox.Location = new System.Drawing.Point(257, 302);
            this.stockAlertTextBox.Name = "stockAlertTextBox";
            this.stockAlertTextBox.Size = new System.Drawing.Size(121, 20);
            this.stockAlertTextBox.TabIndex = 12;
            // 
            // Frmcrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 520);
            this.Controls.Add(idCategorieLabel);
            this.Controls.Add(this.idCategorieComboBox);
            this.Controls.Add(idFournisseurLabel);
            this.Controls.Add(this.idFournisseurComboBox);
            this.Controls.Add(nomProduitLabel);
            this.Controls.Add(this.nomProduitTextBox);
            this.Controls.Add(prixProduitHTLabel);
            this.Controls.Add(this.prixProduitHTTextBox);
            this.Controls.Add(quantiteStockProduitLabel);
            this.Controls.Add(this.quantiteStockProduitTextBox);
            this.Controls.Add(stockAlertLabel);
            this.Controls.Add(this.stockAlertTextBox);
            this.Controls.Add(this.produitBindingNavigator);
            this.Name = "Frmcrud";
            this.Text = "Frmcrud";
            this.Load += new System.EventHandler(this.Frmcrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingNavigator)).EndInit();
            this.produitBindingNavigator.ResumeLayout(false);
            this.produitBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.BindingNavigator produitBindingNavigator;
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
        private System.Windows.Forms.ComboBox idCategorieComboBox;
        private System.Windows.Forms.ComboBox idFournisseurComboBox;
        private System.Windows.Forms.TextBox nomProduitTextBox;
        private System.Windows.Forms.TextBox prixProduitHTTextBox;
        private System.Windows.Forms.TextBox quantiteStockProduitTextBox;
        private System.Windows.Forms.TextBox stockAlertTextBox;


    }
}