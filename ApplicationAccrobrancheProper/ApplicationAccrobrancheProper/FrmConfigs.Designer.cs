﻿namespace ApplicationAccrobrancheProper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigs));
            System.Windows.Forms.Label idCategorieLabel;
            System.Windows.Forms.Label idFournisseurLabel;
            System.Windows.Forms.Label nomProduitLabel;
            System.Windows.Forms.Label prixProduitHTLabel;
            System.Windows.Forms.Label quantiteStockProduitLabel;
            System.Windows.Forms.Label stockAlertLabel;
            System.Windows.Forms.Label idCategorieLabel1;
            System.Windows.Forms.Label libelleCategorieLabel;
            System.Windows.Forms.Label cpFournisseurLabel;
            System.Windows.Forms.Label idFournisseurLabel1;
            System.Windows.Forms.Label nomFournisseurLabel;
            System.Windows.Forms.Label villeFournisseurLabel;
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
            this.idCategorieTextBox = new System.Windows.Forms.TextBox();
            this.libelleCategorieTextBox = new System.Windows.Forms.TextBox();
            this.cpFournisseurTextBox = new System.Windows.Forms.TextBox();
            this.idFournisseurTextBox = new System.Windows.Forms.TextBox();
            this.nomFournisseurTextBox = new System.Windows.Forms.TextBox();
            this.villeFournisseurTextBox = new System.Windows.Forms.TextBox();
            idCategorieLabel = new System.Windows.Forms.Label();
            idFournisseurLabel = new System.Windows.Forms.Label();
            nomProduitLabel = new System.Windows.Forms.Label();
            prixProduitHTLabel = new System.Windows.Forms.Label();
            quantiteStockProduitLabel = new System.Windows.Forms.Label();
            stockAlertLabel = new System.Windows.Forms.Label();
            idCategorieLabel1 = new System.Windows.Forms.Label();
            libelleCategorieLabel = new System.Windows.Forms.Label();
            cpFournisseurLabel = new System.Windows.Forms.Label();
            idFournisseurLabel1 = new System.Windows.Forms.Label();
            nomFournisseurLabel = new System.Windows.Forms.Label();
            villeFournisseurLabel = new System.Windows.Forms.Label();
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
            this.produitBindingNavigator.Size = new System.Drawing.Size(1916, 25);
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
            idCategorieLabel.Location = new System.Drawing.Point(248, 285);
            idCategorieLabel.Name = "idCategorieLabel";
            idCategorieLabel.Size = new System.Drawing.Size(98, 20);
            idCategorieLabel.TabIndex = 1;
            idCategorieLabel.Text = "id Categorie:";
            // 
            // idCategorieComboBox
            // 
            this.idCategorieComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "idCategorie", true));
            this.idCategorieComboBox.FormattingEnabled = true;
            this.idCategorieComboBox.Location = new System.Drawing.Point(424, 282);
            this.idCategorieComboBox.Name = "idCategorieComboBox";
            this.idCategorieComboBox.Size = new System.Drawing.Size(121, 28);
            this.idCategorieComboBox.TabIndex = 2;
            // 
            // idFournisseurLabel
            // 
            idFournisseurLabel.AutoSize = true;
            idFournisseurLabel.Location = new System.Drawing.Point(248, 319);
            idFournisseurLabel.Name = "idFournisseurLabel";
            idFournisseurLabel.Size = new System.Drawing.Size(113, 20);
            idFournisseurLabel.TabIndex = 3;
            idFournisseurLabel.Text = "id Fournisseur:";
            // 
            // idFournisseurComboBox
            // 
            this.idFournisseurComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "idFournisseur", true));
            this.idFournisseurComboBox.FormattingEnabled = true;
            this.idFournisseurComboBox.Location = new System.Drawing.Point(424, 316);
            this.idFournisseurComboBox.Name = "idFournisseurComboBox";
            this.idFournisseurComboBox.Size = new System.Drawing.Size(121, 28);
            this.idFournisseurComboBox.TabIndex = 4;
            // 
            // nomProduitLabel
            // 
            nomProduitLabel.AutoSize = true;
            nomProduitLabel.Location = new System.Drawing.Point(248, 353);
            nomProduitLabel.Name = "nomProduitLabel";
            nomProduitLabel.Size = new System.Drawing.Size(98, 20);
            nomProduitLabel.TabIndex = 5;
            nomProduitLabel.Text = "nom Produit:";
            // 
            // nomProduitTextBox
            // 
            this.nomProduitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "nomProduit", true));
            this.nomProduitTextBox.Location = new System.Drawing.Point(424, 350);
            this.nomProduitTextBox.Name = "nomProduitTextBox";
            this.nomProduitTextBox.Size = new System.Drawing.Size(121, 26);
            this.nomProduitTextBox.TabIndex = 6;
            // 
            // prixProduitHTLabel
            // 
            prixProduitHTLabel.AutoSize = true;
            prixProduitHTLabel.Location = new System.Drawing.Point(248, 385);
            prixProduitHTLabel.Name = "prixProduitHTLabel";
            prixProduitHTLabel.Size = new System.Drawing.Size(116, 20);
            prixProduitHTLabel.TabIndex = 7;
            prixProduitHTLabel.Text = "prix Produit HT:";
            // 
            // prixProduitHTTextBox
            // 
            this.prixProduitHTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixProduitHT", true));
            this.prixProduitHTTextBox.Location = new System.Drawing.Point(424, 382);
            this.prixProduitHTTextBox.Name = "prixProduitHTTextBox";
            this.prixProduitHTTextBox.Size = new System.Drawing.Size(121, 26);
            this.prixProduitHTTextBox.TabIndex = 8;
            // 
            // quantiteStockProduitLabel
            // 
            quantiteStockProduitLabel.AutoSize = true;
            quantiteStockProduitLabel.Location = new System.Drawing.Point(248, 417);
            quantiteStockProduitLabel.Name = "quantiteStockProduitLabel";
            quantiteStockProduitLabel.Size = new System.Drawing.Size(170, 20);
            quantiteStockProduitLabel.TabIndex = 9;
            quantiteStockProduitLabel.Text = "quantite Stock Produit:";
            // 
            // quantiteStockProduitTextBox
            // 
            this.quantiteStockProduitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "quantiteStockProduit", true));
            this.quantiteStockProduitTextBox.Location = new System.Drawing.Point(424, 414);
            this.quantiteStockProduitTextBox.Name = "quantiteStockProduitTextBox";
            this.quantiteStockProduitTextBox.Size = new System.Drawing.Size(121, 26);
            this.quantiteStockProduitTextBox.TabIndex = 10;
            // 
            // stockAlertLabel
            // 
            stockAlertLabel.AutoSize = true;
            stockAlertLabel.Location = new System.Drawing.Point(248, 449);
            stockAlertLabel.Name = "stockAlertLabel";
            stockAlertLabel.Size = new System.Drawing.Size(91, 20);
            stockAlertLabel.TabIndex = 11;
            stockAlertLabel.Text = "Stock Alert:";
            // 
            // stockAlertTextBox
            // 
            this.stockAlertTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "StockAlert", true));
            this.stockAlertTextBox.Location = new System.Drawing.Point(424, 446);
            this.stockAlertTextBox.Name = "stockAlertTextBox";
            this.stockAlertTextBox.Size = new System.Drawing.Size(121, 26);
            this.stockAlertTextBox.TabIndex = 12;
            // 
            // idCategorieLabel1
            // 
            idCategorieLabel1.AutoSize = true;
            idCategorieLabel1.Location = new System.Drawing.Point(248, 515);
            idCategorieLabel1.Name = "idCategorieLabel1";
            idCategorieLabel1.Size = new System.Drawing.Size(98, 20);
            idCategorieLabel1.TabIndex = 13;
            idCategorieLabel1.Text = "id Categorie:";
            // 
            // idCategorieTextBox
            // 
            this.idCategorieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "LaCategorie.idCategorie", true));
            this.idCategorieTextBox.Location = new System.Drawing.Point(379, 512);
            this.idCategorieTextBox.Name = "idCategorieTextBox";
            this.idCategorieTextBox.Size = new System.Drawing.Size(100, 26);
            this.idCategorieTextBox.TabIndex = 14;
            // 
            // libelleCategorieLabel
            // 
            libelleCategorieLabel.AutoSize = true;
            libelleCategorieLabel.Location = new System.Drawing.Point(248, 547);
            libelleCategorieLabel.Name = "libelleCategorieLabel";
            libelleCategorieLabel.Size = new System.Drawing.Size(125, 20);
            libelleCategorieLabel.TabIndex = 15;
            libelleCategorieLabel.Text = "libelle Categorie:";
            // 
            // libelleCategorieTextBox
            // 
            this.libelleCategorieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "LaCategorie.libelleCategorie", true));
            this.libelleCategorieTextBox.Location = new System.Drawing.Point(379, 544);
            this.libelleCategorieTextBox.Name = "libelleCategorieTextBox";
            this.libelleCategorieTextBox.Size = new System.Drawing.Size(100, 26);
            this.libelleCategorieTextBox.TabIndex = 16;
            // 
            // cpFournisseurLabel
            // 
            cpFournisseurLabel.AutoSize = true;
            cpFournisseurLabel.Location = new System.Drawing.Point(248, 613);
            cpFournisseurLabel.Name = "cpFournisseurLabel";
            cpFournisseurLabel.Size = new System.Drawing.Size(118, 20);
            cpFournisseurLabel.TabIndex = 17;
            cpFournisseurLabel.Text = "cp Fournisseur:";
            // 
            // cpFournisseurTextBox
            // 
            this.cpFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "LeFournisseur.cpFournisseur", true));
            this.cpFournisseurTextBox.Location = new System.Drawing.Point(386, 610);
            this.cpFournisseurTextBox.Name = "cpFournisseurTextBox";
            this.cpFournisseurTextBox.Size = new System.Drawing.Size(100, 26);
            this.cpFournisseurTextBox.TabIndex = 18;
            // 
            // idFournisseurLabel1
            // 
            idFournisseurLabel1.AutoSize = true;
            idFournisseurLabel1.Location = new System.Drawing.Point(248, 645);
            idFournisseurLabel1.Name = "idFournisseurLabel1";
            idFournisseurLabel1.Size = new System.Drawing.Size(113, 20);
            idFournisseurLabel1.TabIndex = 19;
            idFournisseurLabel1.Text = "id Fournisseur:";
            // 
            // idFournisseurTextBox
            // 
            this.idFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "LeFournisseur.idFournisseur", true));
            this.idFournisseurTextBox.Location = new System.Drawing.Point(386, 642);
            this.idFournisseurTextBox.Name = "idFournisseurTextBox";
            this.idFournisseurTextBox.Size = new System.Drawing.Size(100, 26);
            this.idFournisseurTextBox.TabIndex = 20;
            // 
            // nomFournisseurLabel
            // 
            nomFournisseurLabel.AutoSize = true;
            nomFournisseurLabel.Location = new System.Drawing.Point(248, 677);
            nomFournisseurLabel.Name = "nomFournisseurLabel";
            nomFournisseurLabel.Size = new System.Drawing.Size(132, 20);
            nomFournisseurLabel.TabIndex = 21;
            nomFournisseurLabel.Text = "nom Fournisseur:";
            // 
            // nomFournisseurTextBox
            // 
            this.nomFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "LeFournisseur.nomFournisseur", true));
            this.nomFournisseurTextBox.Location = new System.Drawing.Point(386, 674);
            this.nomFournisseurTextBox.Name = "nomFournisseurTextBox";
            this.nomFournisseurTextBox.Size = new System.Drawing.Size(100, 26);
            this.nomFournisseurTextBox.TabIndex = 22;
            // 
            // villeFournisseurLabel
            // 
            villeFournisseurLabel.AutoSize = true;
            villeFournisseurLabel.Location = new System.Drawing.Point(248, 709);
            villeFournisseurLabel.Name = "villeFournisseurLabel";
            villeFournisseurLabel.Size = new System.Drawing.Size(126, 20);
            villeFournisseurLabel.TabIndex = 23;
            villeFournisseurLabel.Text = "ville Fournisseur:";
            // 
            // villeFournisseurTextBox
            // 
            this.villeFournisseurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "LeFournisseur.villeFournisseur", true));
            this.villeFournisseurTextBox.Location = new System.Drawing.Point(386, 706);
            this.villeFournisseurTextBox.Name = "villeFournisseurTextBox";
            this.villeFournisseurTextBox.Size = new System.Drawing.Size(100, 26);
            this.villeFournisseurTextBox.TabIndex = 24;
            // 
            // FrmConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1916, 1020);
            this.Controls.Add(cpFournisseurLabel);
            this.Controls.Add(this.cpFournisseurTextBox);
            this.Controls.Add(idFournisseurLabel1);
            this.Controls.Add(this.idFournisseurTextBox);
            this.Controls.Add(nomFournisseurLabel);
            this.Controls.Add(this.nomFournisseurTextBox);
            this.Controls.Add(villeFournisseurLabel);
            this.Controls.Add(this.villeFournisseurTextBox);
            this.Controls.Add(idCategorieLabel1);
            this.Controls.Add(this.idCategorieTextBox);
            this.Controls.Add(libelleCategorieLabel);
            this.Controls.Add(this.libelleCategorieTextBox);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConfigs";
            this.Text = "Réglages Logiciel";
            this.Load += new System.EventHandler(this.FrmConfigs_Load);
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
        private System.Windows.Forms.TextBox idCategorieTextBox;
        private System.Windows.Forms.TextBox libelleCategorieTextBox;
        private System.Windows.Forms.TextBox cpFournisseurTextBox;
        private System.Windows.Forms.TextBox idFournisseurTextBox;
        private System.Windows.Forms.TextBox nomFournisseurTextBox;
        private System.Windows.Forms.TextBox villeFournisseurTextBox;


    }
}