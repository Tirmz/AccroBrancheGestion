namespace ApplicationAccrobrancheProper
{
    partial class FrmVente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVente));
            this.cbx_nameboisson = new System.Windows.Forms.ComboBox();
            this.cbx_namegateau = new System.Windows.Forms.ComboBox();
            this.cbx_nameglaces = new System.Windows.Forms.ComboBox();
            this.cbx_nameEquipments = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_gateau = new System.Windows.Forms.Label();
            this.lb_glacon = new System.Windows.Forms.Label();
            this.lb_boissons = new System.Windows.Forms.Label();
            this.num_boissons = new System.Windows.Forms.NumericUpDown();
            this.num_gateaux = new System.Windows.Forms.NumericUpDown();
            this.num_glaces = new System.Windows.Forms.NumericUpDown();
            this.num_equipments = new System.Windows.Forms.NumericUpDown();
            this.bt_validateboisson = new System.Windows.Forms.Button();
            this.bt_validategateau = new System.Windows.Forms.Button();
            this.bt_validateglace = new System.Windows.Forms.Button();
            this.bt_validateequipments = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_recapvente = new System.Windows.Forms.Label();
            this.bt_validatevente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_boissons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_gateaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_glaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_equipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_nameboisson
            // 
            this.cbx_nameboisson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_nameboisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nameboisson.FormattingEnabled = true;
            this.cbx_nameboisson.Location = new System.Drawing.Point(69, 68);
            this.cbx_nameboisson.Name = "cbx_nameboisson";
            this.cbx_nameboisson.Size = new System.Drawing.Size(233, 37);
            this.cbx_nameboisson.TabIndex = 0;
            // 
            // cbx_namegateau
            // 
            this.cbx_namegateau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_namegateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_namegateau.FormattingEnabled = true;
            this.cbx_namegateau.Location = new System.Drawing.Point(359, 68);
            this.cbx_namegateau.Name = "cbx_namegateau";
            this.cbx_namegateau.Size = new System.Drawing.Size(233, 37);
            this.cbx_namegateau.TabIndex = 1;
            // 
            // cbx_nameglaces
            // 
            this.cbx_nameglaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_nameglaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nameglaces.FormattingEnabled = true;
            this.cbx_nameglaces.Location = new System.Drawing.Point(659, 68);
            this.cbx_nameglaces.Name = "cbx_nameglaces";
            this.cbx_nameglaces.Size = new System.Drawing.Size(233, 37);
            this.cbx_nameglaces.TabIndex = 2;
            // 
            // cbx_nameEquipments
            // 
            this.cbx_nameEquipments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_nameEquipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nameEquipments.FormattingEnabled = true;
            this.cbx_nameEquipments.Location = new System.Drawing.Point(959, 68);
            this.cbx_nameEquipments.Name = "cbx_nameEquipments";
            this.cbx_nameEquipments.Size = new System.Drawing.Size(278, 37);
            this.cbx_nameEquipments.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_validateequipments);
            this.groupBox1.Controls.Add(this.bt_validateglace);
            this.groupBox1.Controls.Add(this.bt_validategateau);
            this.groupBox1.Controls.Add(this.bt_validateboisson);
            this.groupBox1.Controls.Add(this.num_equipments);
            this.groupBox1.Controls.Add(this.num_glaces);
            this.groupBox1.Controls.Add(this.num_gateaux);
            this.groupBox1.Controls.Add(this.num_boissons);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_gateau);
            this.groupBox1.Controls.Add(this.lb_glacon);
            this.groupBox1.Controls.Add(this.lb_boissons);
            this.groupBox1.Controls.Add(this.cbx_nameboisson);
            this.groupBox1.Controls.Add(this.cbx_nameEquipments);
            this.groupBox1.Controls.Add(this.cbx_namegateau);
            this.groupBox1.Controls.Add(this.cbx_nameglaces);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1286, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1033, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Equipements :";
            // 
            // lb_gateau
            // 
            this.lb_gateau.AutoSize = true;
            this.lb_gateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gateau.Location = new System.Drawing.Point(729, 34);
            this.lb_gateau.Name = "lb_gateau";
            this.lb_gateau.Size = new System.Drawing.Size(78, 24);
            this.lb_gateau.TabIndex = 7;
            this.lb_gateau.Text = "Glaces :";
            // 
            // lb_glacon
            // 
            this.lb_glacon.AutoSize = true;
            this.lb_glacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_glacon.Location = new System.Drawing.Point(437, 34);
            this.lb_glacon.Name = "lb_glacon";
            this.lb_glacon.Size = new System.Drawing.Size(90, 24);
            this.lb_glacon.TabIndex = 6;
            this.lb_glacon.Text = "Gâteaux :";
            // 
            // lb_boissons
            // 
            this.lb_boissons.AutoSize = true;
            this.lb_boissons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_boissons.Location = new System.Drawing.Point(136, 34);
            this.lb_boissons.Name = "lb_boissons";
            this.lb_boissons.Size = new System.Drawing.Size(96, 24);
            this.lb_boissons.TabIndex = 5;
            this.lb_boissons.Text = "Boissons :";
            // 
            // num_boissons
            // 
            this.num_boissons.Location = new System.Drawing.Point(125, 111);
            this.num_boissons.Name = "num_boissons";
            this.num_boissons.Size = new System.Drawing.Size(120, 31);
            this.num_boissons.TabIndex = 9;
            // 
            // num_gateaux
            // 
            this.num_gateaux.Location = new System.Drawing.Point(407, 111);
            this.num_gateaux.Name = "num_gateaux";
            this.num_gateaux.Size = new System.Drawing.Size(120, 31);
            this.num_gateaux.TabIndex = 10;
            // 
            // num_glaces
            // 
            this.num_glaces.Location = new System.Drawing.Point(714, 111);
            this.num_glaces.Name = "num_glaces";
            this.num_glaces.Size = new System.Drawing.Size(120, 31);
            this.num_glaces.TabIndex = 11;
            // 
            // num_equipments
            // 
            this.num_equipments.Location = new System.Drawing.Point(1054, 111);
            this.num_equipments.Name = "num_equipments";
            this.num_equipments.Size = new System.Drawing.Size(120, 31);
            this.num_equipments.TabIndex = 12;
            // 
            // bt_validateboisson
            // 
            this.bt_validateboisson.Location = new System.Drawing.Point(130, 149);
            this.bt_validateboisson.Name = "bt_validateboisson";
            this.bt_validateboisson.Size = new System.Drawing.Size(102, 35);
            this.bt_validateboisson.TabIndex = 5;
            this.bt_validateboisson.Text = "Valider";
            this.bt_validateboisson.UseVisualStyleBackColor = true;
            this.bt_validateboisson.Click += new System.EventHandler(this.bt_validateboisson_Click);
            // 
            // bt_validategateau
            // 
            this.bt_validategateau.Location = new System.Drawing.Point(416, 148);
            this.bt_validategateau.Name = "bt_validategateau";
            this.bt_validategateau.Size = new System.Drawing.Size(102, 35);
            this.bt_validategateau.TabIndex = 13;
            this.bt_validategateau.Text = "Valider";
            this.bt_validategateau.UseVisualStyleBackColor = true;
            // 
            // bt_validateglace
            // 
            this.bt_validateglace.Location = new System.Drawing.Point(723, 148);
            this.bt_validateglace.Name = "bt_validateglace";
            this.bt_validateglace.Size = new System.Drawing.Size(102, 35);
            this.bt_validateglace.TabIndex = 14;
            this.bt_validateglace.Text = "Valider";
            this.bt_validateglace.UseVisualStyleBackColor = true;
            // 
            // bt_validateequipments
            // 
            this.bt_validateequipments.Location = new System.Drawing.Point(1063, 148);
            this.bt_validateequipments.Name = "bt_validateequipments";
            this.bt_validateequipments.Size = new System.Drawing.Size(102, 35);
            this.bt_validateequipments.TabIndex = 15;
            this.bt_validateequipments.Text = "Valider";
            this.bt_validateequipments.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1121, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // lb_recapvente
            // 
            this.lb_recapvente.AutoSize = true;
            this.lb_recapvente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recapvente.Location = new System.Drawing.Point(77, 304);
            this.lb_recapvente.Name = "lb_recapvente";
            this.lb_recapvente.Size = new System.Drawing.Size(248, 24);
            this.lb_recapvente.TabIndex = 6;
            this.lb_recapvente.Text = "Récapitulatif de la Vente :";
            // 
            // bt_validatevente
            // 
            this.bt_validatevente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_validatevente.Location = new System.Drawing.Point(564, 518);
            this.bt_validatevente.Name = "bt_validatevente";
            this.bt_validatevente.Size = new System.Drawing.Size(102, 35);
            this.bt_validatevente.TabIndex = 16;
            this.bt_validatevente.Text = "Valider";
            this.bt_validatevente.UseVisualStyleBackColor = true;
            // 
            // FrmVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 821);
            this.Controls.Add(this.bt_validatevente);
            this.Controls.Add(this.lb_recapvente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVente";
            this.Text = "Formulaire De Vente";
            this.Load += new System.EventHandler(this.FrmVente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_boissons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_gateaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_glaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_equipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_nameboisson;
        private System.Windows.Forms.ComboBox cbx_namegateau;
        private System.Windows.Forms.ComboBox cbx_nameglaces;
        private System.Windows.Forms.ComboBox cbx_nameEquipments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_gateau;
        private System.Windows.Forms.Label lb_glacon;
        private System.Windows.Forms.Label lb_boissons;
        private System.Windows.Forms.Button bt_validateequipments;
        private System.Windows.Forms.Button bt_validateglace;
        private System.Windows.Forms.Button bt_validategateau;
        private System.Windows.Forms.Button bt_validateboisson;
        private System.Windows.Forms.NumericUpDown num_equipments;
        private System.Windows.Forms.NumericUpDown num_glaces;
        private System.Windows.Forms.NumericUpDown num_gateaux;
        private System.Windows.Forms.NumericUpDown num_boissons;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_recapvente;
        private System.Windows.Forms.Button bt_validatevente;

    }
}