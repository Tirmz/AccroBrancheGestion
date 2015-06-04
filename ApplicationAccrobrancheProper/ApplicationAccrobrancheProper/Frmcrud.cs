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
    public partial class Frmcrud : Form
    {
        private Modele bd;
        public Frmcrud(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.Produit.ToList();
            bsCategorie.DataSource = bd.Categorie.ToList();
            bsFournisseur.DataSource = bd.Fournisseur.ToList();
        }

        private void Frmcrud_Load(object sender, EventArgs e)
        {
            setDiplay();
        }

        private void setDiplay()
        {
            // Modification du nom des onglets
            tabPage1.Text = "Produits";
            tabPage2.Text = "Catégories";
            tabPage3.Text = "Fournisseurs";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bt_addProduct_Click(object sender, EventArgs e)
        {
            FrmAjoutProduit frm = new FrmAjoutProduit(bd);
            frm.ShowDialog();
            bs.DataSource = bd.Produit.ToList();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dg_products.CurrentRow.Cells[0].Value);
            Produit produitmodif = bd.Produit.Find(id);
            FrmModifProduit frm = new FrmModifProduit(bd, produitmodif);
            frm.ShowDialog();
            bs.DataSource = bd.Produit.ToList();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dg_products.CurrentRow.Cells[0].Value);
            Produit produitToDelete = bd.Produit.Find(id);
            bd.Produit.Remove(produitToDelete);
            bd.SaveChanges();
            MessageBox.Show("Suppression Effectuée");
            bs.DataSource = bd.Produit.ToList();
        }
    }
}
