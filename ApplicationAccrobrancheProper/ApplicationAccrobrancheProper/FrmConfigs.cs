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
    public partial class FrmConfigs : Form
    {
        private Modele bd;
        public FrmConfigs(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bsProduits.DataSource = bd.Produit.ToList();
        }

        private void bsProduits_CurrentChanged(object sender, EventArgs e)
        {
            if (bsProduits.Current != null)
            {
                bd.SaveChanges();
            }
        }

        private void produitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (bsProduits.Current != null)
            {
                bsProduits.EndEdit();
                Produit produit = new Produit();
                produit.idCategorie = Convert.ToInt32(idCategorieTextBox.Text);
                produit.idFournisseur = Convert.ToInt32(idFournisseurTextBox.Text);
                produit.nomProduit = nomProduitTextBox.Text;
                produit.prixProduitHT = float.Parse(prixProduitHTTextBox.Text);
                produit.quantiteStockProduit = Convert.ToInt32(quantiteStockProduitTextBox.Text);
                produit.StockAlert = Convert.ToInt32(stockAlertTextBox.Text);
                bd.Produit.Add(produit);
                bd.SaveChanges();
            }
        }

        private void FrmConfigs_Load(object sender, EventArgs e)
        {
            if (bsProduits.Current != null)
            {
                bsProduits.EndEdit();
                bd.SaveChanges();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Produit leproduit = (Produit)bsProduits.Current;
            bd.Produit.Attach(leproduit);
            bd.Produit.Remove(leproduit);
            bd.SaveChanges();
        }
    }
}
