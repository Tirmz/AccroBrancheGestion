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
    
    public partial class FrmAjoutProduit : Form
    {
        private Modele bd;
        public FrmAjoutProduit(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            setDisplay();
        }

        private void setDisplay()
        {
            fillcbxCategorie();
            fillcbxFournisseur();
        }
        private void fillcbxCategorie()
        {
            // Requête LINQ permettant de lister les produits en fonction de la catégorie.
            var fillcombobox = (from p in bd.Categorie
                                select p);
            cbx_categorie.DataSource = fillcombobox.ToList();
            cbx_categorie.DisplayMember = "libelleCategorie";
            cbx_categorie.ValueMember = "idCategorie";
        }
        private void fillcbxFournisseur()
        {
            // Requête LINQ permettant de lister les produits en fonction de la catégorie.
            var fillcombobox = (from p in bd.Fournisseur
                                select p);
            cbx_fournisseur.DataSource = fillcombobox.ToList();
            cbx_fournisseur.DisplayMember = "nomFournisseur";
            cbx_fournisseur.ValueMember = "idFournisseur";
        }

        private void bt_validateAjout_Click(object sender, EventArgs e)
        {
            Produit leproduit = new Produit();
            leproduit.nomProduit = txt_nameProduct.Text;
            leproduit.prixProduitHT = Single.Parse(txt_prix.Text);
            leproduit.quantiteStockProduit = Convert.ToInt32(num_quantite.Value);
            leproduit.StockAlert = Convert.ToInt32(num_alert.Value);
            leproduit.idCategorie = Convert.ToInt32(cbx_categorie.SelectedValue);
            leproduit.idFournisseur = Convert.ToInt32(cbx_fournisseur.SelectedValue);
            bd.Produit.Add(leproduit);
            bd.SaveChanges();

            MessageBox.Show("Produit Ajouté");
            this.Close();
            }

        private void FrmAjoutProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
