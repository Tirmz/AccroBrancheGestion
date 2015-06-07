namespace ApplicationAccrobrancheProper
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.bt_GoGestionCaisse = new System.Windows.Forms.Button();
            this.lb_nameComputer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_GoGestionCaisse
            // 
            this.bt_GoGestionCaisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoGestionCaisse.Location = new System.Drawing.Point(388, 145);
            this.bt_GoGestionCaisse.Name = "bt_GoGestionCaisse";
            this.bt_GoGestionCaisse.Size = new System.Drawing.Size(334, 208);
            this.bt_GoGestionCaisse.TabIndex = 0;
            this.bt_GoGestionCaisse.Text = "Gestion de Stock/Caisse";
            this.bt_GoGestionCaisse.UseVisualStyleBackColor = true;
            this.bt_GoGestionCaisse.Click += new System.EventHandler(this.bt_GoGestionCaisse_Click);
            // 
            // lb_nameComputer
            // 
            this.lb_nameComputer.AutoSize = true;
            this.lb_nameComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameComputer.Location = new System.Drawing.Point(413, 95);
            this.lb_nameComputer.Name = "lb_nameComputer";
            this.lb_nameComputer.Size = new System.Drawing.Size(108, 31);
            this.lb_nameComputer.TabIndex = 1;
            this.lb_nameComputer.Text = "nom pc";
            this.lb_nameComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1208, 512);
            this.Controls.Add(this.lb_nameComputer);
            this.Controls.Add(this.bt_GoGestionCaisse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FrmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_GoGestionCaisse;
        private System.Windows.Forms.Label lb_nameComputer;
    }
}

