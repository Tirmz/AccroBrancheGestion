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
            this.cbx_nameboisson = new System.Windows.Forms.ComboBox();
            this.cbx_namegateau = new System.Windows.Forms.ComboBox();
            this.cbx_nameglaces = new System.Windows.Forms.ComboBox();
            this.cbx_nameEquipments = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_boissons = new System.Windows.Forms.Label();
            this.lb_glacon = new System.Windows.Forms.Label();
            this.lb_gateau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1286, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produits";
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
            // FrmVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 821);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVente";
            this.Text = "Formulaire De Vente";
            this.Load += new System.EventHandler(this.FrmVente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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

    }
}