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
    public partial class FrmModifProduit : Form
    {
        private Modele bd;
        private Produit produitModif;
        public FrmModifProduit(Modele p_bd, Produit produit)
        {
            InitializeComponent();
            bd = p_bd;
            produitModif = produit;
            txt_nameProduct.Text = produitModif.nomProduit;
            txt_prix.Text = produitModif.prixProduitHT.ToString();
            num_quantite.Value = produitModif.quantiteStockProduit;
            num_alert.Value = produitModif.StockAlert;
        }

        private void setDisplay()
        {
            cbx_categorie.DataSource = bd.Categorie.ToList();
            cbx_categorie.DisplayMember = "libelleCategorie";
            cbx_categorie.ValueMember = "idCategorie";

            cbx_fournisseur.DataSource = bd.Fournisseur.ToList();
            cbx_fournisseur.DisplayMember = "nomFournisseur";
            cbx_fournisseur.ValueMember = "idFournisseur";

            int index = produitModif.idCategorie;
            cbx_categorie.SelectedIndex = index - 1;
            int index2 = produitModif.idFournisseur;
            cbx_fournisseur.SelectedIndex = index2 - 1;
        }

        private void FrmModifProduit_Load(object sender, EventArgs e)
        {
            setDisplay();
        }

        private void bt_validateAjout_Click(object sender, EventArgs e)
        {
            produitModif.nomProduit = txt_nameProduct.Text;
            produitModif.prixProduitHT = Single.Parse(txt_prix.Text);
            produitModif.quantiteStockProduit = Convert.ToInt32(num_quantite.Value);
            produitModif.StockAlert = Convert.ToInt32(num_alert.Value);
            produitModif.idCategorie = Convert.ToInt32(cbx_categorie.SelectedValue);
            produitModif.idFournisseur = Convert.ToInt32(cbx_fournisseur.SelectedValue);
            bd.Entry(produitModif).State = EntityState.Modified;
            bd.SaveChanges();
            MessageBox.Show("Modification effectuée");
            this.Close();
        }
    }
}
