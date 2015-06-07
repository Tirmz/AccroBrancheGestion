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
            // Modification du nom des onglets du tabcontrol
            tabPage1.Text = "Produits";
            tabPage2.Text = "Catégories";
            tabPage3.Text = "Fournisseurs";
        }
        #region CRUD Produits
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
        #endregion

        #region CRUD Catégories
        private void bt_addCategorie_Click(object sender, EventArgs e)
        {
            FrmAjoutCategorie frm = new FrmAjoutCategorie(bd);
            frm.ShowDialog();
            bsCategorie.DataSource = bd.Categorie.ToList();
        }

        private void bt_updateCategorie_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dg_categories.CurrentRow.Cells[0].Value);
            Categorie categoriemodifiee = bd.Categorie.Find(id);
            FrmModifCategorie frm = new FrmModifCategorie(bd, categoriemodifiee);
            frm.ShowDialog();
            bsCategorie.DataSource = bd.Categorie.ToList();
        }

        private void bt_deleteCategorie_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dg_categories.CurrentRow.Cells[0].Value);
            Categorie categorietodelete = bd.Categorie.Find(id);
            bd.Categorie.Remove(categorietodelete);
            bd.SaveChanges();
            MessageBox.Show("Suppression Effectuée");
            bsCategorie.DataSource = bd.Categorie.ToList();
        }
        #endregion

        #region CRUD Fournisseurs
        private void bt_addFournissseur_Click(object sender, EventArgs e)
        {
            FrmAjoutFournisseur frm = new FrmAjoutFournisseur(bd);
            frm.ShowDialog();
            bsFournisseur.DataSource = bd.Fournisseur.ToList();
        }

        private void bt_updateFournissseur_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dg_fournisseur.CurrentRow.Cells[0].Value);
            Fournisseur fournisseurmodifie = bd.Fournisseur.Find(id);
            FrmModifFournisseur frm = new FrmModifFournisseur(bd, fournisseurmodifie);
            frm.ShowDialog();
            bsFournisseur.DataSource = bd.Fournisseur.ToList();
        }

        private void bt_deleteFournisseur_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dg_fournisseur.CurrentRow.Cells[0].Value);
            Fournisseur fournisseurtodelete = bd.Fournisseur.Find(id);
            bd.Fournisseur.Remove(fournisseurtodelete);
            bd.SaveChanges();
            MessageBox.Show("Suppression Effectuée");
            bsFournisseur.DataSource = bd.Fournisseur.ToList();
        }
        #endregion
    }
}
