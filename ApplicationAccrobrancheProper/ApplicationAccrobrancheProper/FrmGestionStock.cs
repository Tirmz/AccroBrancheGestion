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
    public partial class FrmGestionStock : Form
    {
        private Modele bd;
        public FrmGestionStock(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.Produit.ToList();
        }

        /// <summary>
        /// Fonction permettant de gèrer les sauvegardes, et sauvegardes après suppressions
        /// </summary>
        private void produitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                bd.SaveChanges();
            }
        }

      /*  private void bs_CurrentChanged(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();
            }
        }*/

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Produit leproduit = (Produit)bs.Current;
            bd.Produit.Attach(leproduit);
            bd.Produit.Remove(leproduit);
            bd.SaveChanges();
        }
        /// <summary>
        /// Fonction Permettant la colorisation d'un ligne du DataGridView si un produit nécessite un réaprovisionnement
        /// </summary>
        private void setRedStockAlert()
        {
            foreach (DataGridViewRow row in produitDataGridView.Rows)
            {
                int cell1 = Convert.ToInt32(row.Cells[2].Value);
                int cell2 = Convert.ToInt32(row.Cells[3].Value);
                if (cell1 < cell2)
                {
                    row.DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }

        /// <summary>
        /// Fonction permettant de vérifier chaque ligne du DataGridView, si une est rose, alors le message de rappel s'affiche en bas
        /// </summary>
        private void setMessageEtatStock()
        {
            foreach (DataGridViewRow row in produitDataGridView.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Pink)
                {
                    lb_rappelStock.Visible = true;
                    lb_rappelStock.Text = "ATTENTION : Des produits nécessitent un réaprovisionnement";
                }
            }
        }

        private void FrmGestionStock_Load(object sender, EventArgs e)
        {
            setRedStockAlert();
            setMessageEtatStock();
        }

        /// <summary>
        /// Fonction permettant de renvoyer les détails du fournisseurs d'un produit (affiche un nouveau formulaire).
        /// </summary>
        private void produitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (produitDataGridView.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn9")
            {
                Produit leproduit = (Produit)produitDataGridView.CurrentRow.DataBoundItem;
                if (leproduit != null)
                {
                    FrmDetailsFournisseur detail = new FrmDetailsFournisseur(bd, leproduit);
                    detail.ShowDialog();
                }
            }
        }
        /// <summary>
        /// Ouvre le formulaire du Chiffre d'affaire et des ventes effectuées.
        /// </summary>
        private void bt_watchEarnings_Click(object sender, EventArgs e)
        {
            FrmChiffreAffaire frm = new FrmChiffreAffaire(bd);
            frm.Show();
        }
        
        /// <summary>
        /// Permet d'afficher seulement les produits proches de la rupture de stock.
        /// </summary>
        private void cbx_productinalert_CheckedChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in produitDataGridView.Rows)
            {
                    if (row.DefaultCellStyle.BackColor != Color.Pink)
                    {
                        row.Visible = false;
                    }
            }
        }

        /// <summary>
        /// Ouvre le formulaire permettant d'effectuer une vente.
        /// </summary>
        private void bt_goDoSale_Click(object sender, EventArgs e)
        {
            FrmVente frm = new FrmVente(bd);
            frm.ShowDialog();
            System.Data.Objects.ObjectContext context = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)bd).ObjectContext;
            context.Refresh(System.Data.Objects.RefreshMode.StoreWins, bd.Produit);
            bs.DataSource = bd.Produit.ToList();
            setRedStockAlert();
            setMessageEtatStock();
        }
        /// <summary>
        /// Ouvre le formulaire permettant de configurer les Produits, fournisseurs, catégorie (Méthodes CRUD).
        /// </summary>
        private void bt_goConfigs_Click(object sender, EventArgs e)
        {
            Frmcrud frm = new Frmcrud(bd);
            frm.ShowDialog();
            bs.DataSource = bd.Produit.ToList();
            setRedStockAlert();
            setMessageEtatStock();
        }
    }
}
