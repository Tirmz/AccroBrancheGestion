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
            this.bt_GoGestionCaisse = new System.Windows.Forms.Button();
            this.bt_GoGestionEpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_GoGestionCaisse
            // 
            this.bt_GoGestionCaisse.Location = new System.Drawing.Point(131, 123);
            this.bt_GoGestionCaisse.Name = "bt_GoGestionCaisse";
            this.bt_GoGestionCaisse.Size = new System.Drawing.Size(334, 208);
            this.bt_GoGestionCaisse.TabIndex = 0;
            this.bt_GoGestionCaisse.Text = "Gestion de Stock/Caisse";
            this.bt_GoGestionCaisse.UseVisualStyleBackColor = true;
            this.bt_GoGestionCaisse.Click += new System.EventHandler(this.bt_GoGestionCaisse_Click);
            // 
            // bt_GoGestionEpis
            // 
            this.bt_GoGestionEpis.Location = new System.Drawing.Point(685, 123);
            this.bt_GoGestionEpis.Name = "bt_GoGestionEpis";
            this.bt_GoGestionEpis.Size = new System.Drawing.Size(286, 208);
            this.bt_GoGestionEpis.TabIndex = 1;
            this.bt_GoGestionEpis.Text = "Gestion des Equipements de Protection Individuels (EPI)";
            this.bt_GoGestionEpis.UseVisualStyleBackColor = true;
            this.bt_GoGestionEpis.Click += new System.EventHandler(this.bt_GoGestionEpis_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 512);
            this.Controls.Add(this.bt_GoGestionEpis);
            this.Controls.Add(this.bt_GoGestionCaisse);
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_GoGestionCaisse;
        private System.Windows.Forms.Button bt_GoGestionEpis;
    }
}

