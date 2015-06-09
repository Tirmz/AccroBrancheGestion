namespace ApplicationAccrobrancheProper
{
    partial class FrmGestionStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_titleGestionStock = new System.Windows.Forms.Label();
            this.bt_goDoSale = new System.Windows.Forms.Button();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.produitDataGridView = new System.Windows.Forms.DataGridView();
            this.GetPrixTCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_rappelStock = new System.Windows.Forms.Label();
            this.bt_watchEarnings = new System.Windows.Forms.Button();
            this.bt_goConfigs = new System.Windows.Forms.Button();
            this.cbx_productinalert = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titleGestionStock
            // 
            this.lb_titleGestionStock.AutoSize = true;
            this.lb_titleGestionStock.BackColor = System.Drawing.Color.Transparent;
            this.lb_titleGestionStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleGestionStock.ForeColor = System.Drawing.Color.White;
            this.lb_titleGestionStock.Location = new System.Drawing.Point(482, 25);
            this.lb_titleGestionStock.Name = "lb_titleGestionStock";
            this.lb_titleGestionStock.Size = new System.Drawing.Size(207, 33);
            this.lb_titleGestionStock.TabIndex = 0;
            this.lb_titleGestionStock.Text = "Les Produits :";
            // 
            // bt_goDoSale
            // 
            this.bt_goDoSale.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_goDoSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_goDoSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_goDoSale.ForeColor = System.Drawing.Color.White;
            this.bt_goDoSale.Location = new System.Drawing.Point(12, 45);
            this.bt_goDoSale.Name = "bt_goDoSale";
            this.bt_goDoSale.Size = new System.Drawing.Size(244, 197);
            this.bt_goDoSale.TabIndex = 1;
            this.bt_goDoSale.Text = "FAIRE UNE VENTE";
            this.bt_goDoSale.UseVisualStyleBackColor = false;
            this.bt_goDoSale.Click += new System.EventHandler(this.bt_goDoSale_Click);
            // 
            // bn
            // 
            this.bn.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn.BindingSource = this.bs;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(1484, 25);
            this.bn.TabIndex = 2;
            this.bn.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // produitDataGridView
            // 
            this.produitDataGridView.AutoGenerateColumns = false;
            this.produitDataGridView.BackgroundColor = System.Drawing.Color.Teal;
            this.produitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.GetPrixTCC});
            this.produitDataGridView.DataSource = this.bs;
            this.produitDataGridView.GridColor = System.Drawing.Color.Red;
            this.produitDataGridView.Location = new System.Drawing.Point(276, 74);
            this.produitDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.produitDataGridView.Name = "produitDataGridView";
            this.produitDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Adobe Caslon Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.produitDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.produitDataGridView.RowTemplate.Height = 30;
            this.produitDataGridView.Size = new System.Drawing.Size(1093, 531);
            this.produitDataGridView.TabIndex = 3;
            this.produitDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produitDataGridView_CellContentClick);
            // 
            // GetPrixTCC
            // 
            this.GetPrixTCC.DataPropertyName = "GetPrixTCC";
            this.GetPrixTCC.HeaderText = "Prix TTC";
            this.GetPrixTCC.Name = "GetPrixTCC";
            this.GetPrixTCC.ReadOnly = true;
            // 
            // lb_rappelStock
            // 
            this.lb_rappelStock.AutoSize = true;
            this.lb_rappelStock.BackColor = System.Drawing.Color.Transparent;
            this.lb_rappelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rappelStock.ForeColor = System.Drawing.Color.Red;
            this.lb_rappelStock.Location = new System.Drawing.Point(271, 618);
            this.lb_rappelStock.Name = "lb_rappelStock";
            this.lb_rappelStock.Size = new System.Drawing.Size(127, 25);
            this.lb_rappelStock.TabIndex = 4;
            this.lb_rappelStock.Text = "Stock Alert";
            this.lb_rappelStock.Visible = false;
            // 
            // bt_watchEarnings
            // 
            this.bt_watchEarnings.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_watchEarnings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_watchEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_watchEarnings.ForeColor = System.Drawing.Color.White;
            this.bt_watchEarnings.Location = new System.Drawing.Point(12, 248);
            this.bt_watchEarnings.Name = "bt_watchEarnings";
            this.bt_watchEarnings.Size = new System.Drawing.Size(244, 197);
            this.bt_watchEarnings.TabIndex = 5;
            this.bt_watchEarnings.Text = "CHIFFRE D\'AFFAIRE";
            this.bt_watchEarnings.UseVisualStyleBackColor = false;
            this.bt_watchEarnings.Click += new System.EventHandler(this.bt_watchEarnings_Click);
            // 
            // bt_goConfigs
            // 
            this.bt_goConfigs.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_goConfigs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_goConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_goConfigs.ForeColor = System.Drawing.Color.White;
            this.bt_goConfigs.Location = new System.Drawing.Point(12, 451);
            this.bt_goConfigs.Name = "bt_goConfigs";
            this.bt_goConfigs.Size = new System.Drawing.Size(244, 197);
            this.bt_goConfigs.TabIndex = 6;
            this.bt_goConfigs.Text = "OPTIONS";
            this.bt_goConfigs.UseVisualStyleBackColor = false;
            this.bt_goConfigs.Click += new System.EventHandler(this.bt_goConfigs_Click);
            // 
            // cbx_productinalert
            // 
            this.cbx_productinalert.AutoSize = true;
            this.cbx_productinalert.BackColor = System.Drawing.Color.Transparent;
            this.cbx_productinalert.ForeColor = System.Drawing.Color.White;
            this.cbx_productinalert.Location = new System.Drawing.Point(276, 50);
            this.cbx_productinalert.Name = "cbx_productinalert";
            this.cbx_productinalert.Size = new System.Drawing.Size(109, 17);
            this.cbx_productinalert.TabIndex = 7;
            this.cbx_productinalert.Text = "Produits en Alerte";
            this.cbx_productinalert.UseVisualStyleBackColor = false;
            this.cbx_productinalert.CheckedChanged += new System.EventHandler(this.cbx_productinalert_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProduit";
            this.dataGridViewTextBoxColumn1.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomProduit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 54;
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
            this.dataGridViewTextBoxColumn5.HeaderText = "Seuil Rappel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prixProduitHT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix HT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GetCategorie";
            this.dataGridViewTextBoxColumn8.HeaderText = "Catégorie";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "GetFournisseur";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fournisseur";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.Width = 86;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ApplicationAccrobrancheProper.Produit);
            this.bs.CurrentChanged += new System.EventHandler(this.bs_CurrentChanged);
            // 
            // FrmGestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.cbx_productinalert);
            this.Controls.Add(this.bt_goConfigs);
            this.Controls.Add(this.bt_watchEarnings);
            this.Controls.Add(this.lb_rappelStock);
            this.Controls.Add(this.produitDataGridView);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.bt_goDoSale);
            this.Controls.Add(this.lb_titleGestionStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionStock";
            this.Text = "Gestion du Stock";
            this.Load += new System.EventHandler(this.FrmGestionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titleGestionStock;
        private System.Windows.Forms.Button bt_goDoSale;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingNavigator bn;
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
        private System.Windows.Forms.DataGridView produitDataGridView;
        private System.Windows.Forms.Label lb_rappelStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn GetPrixTCC;
        private System.Windows.Forms.Button bt_watchEarnings;
        private System.Windows.Forms.Button bt_goConfigs;
        private System.Windows.Forms.CheckBox cbx_productinalert;
    }
}