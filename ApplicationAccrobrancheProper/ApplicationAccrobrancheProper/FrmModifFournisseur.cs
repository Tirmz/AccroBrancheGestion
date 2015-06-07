using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationAccrobrancheProper
{
    public partial class FrmModifFournisseur : Form
    {
        Modele bd;
        Fournisseur fournisseurmodif;
        public FrmModifFournisseur(Modele p_bd, Fournisseur fournisseur)
        {
            InitializeComponent();
            bd = p_bd;
            fournisseurmodif = fournisseur;
            txt_namefour.Text = fournisseurmodif.nomFournisseur;
            txt_villefour.Text = fournisseur.villeFournisseur;
            txt_cpfour.Text = fournisseur.cpFournisseur;
        }

        private void bt_validateModif_Click(object sender, EventArgs e)
        {
            fournisseurmodif.nomFournisseur = txt_namefour.Text;
            fournisseurmodif.villeFournisseur = txt_villefour.Text;
            fournisseurmodif.cpFournisseur = txt_cpfour.Text;
            bd.Entry(fournisseurmodif).State = EntityState.Modified;
            bd.SaveChanges();
            MessageBox.Show("Fournisseur modifié");
            this.Close();
        }
    }
}
