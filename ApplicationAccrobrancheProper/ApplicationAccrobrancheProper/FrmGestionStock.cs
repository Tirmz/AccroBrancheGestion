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

        private void produitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                bd.SaveChanges();
            }
        }

        private void bs_CurrentChanged(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();
            }
        }

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
        private void button1_Click(object sender, EventArgs e)
        {
            FrmConfigs frm = new FrmConfigs(bd);
            frm.Show();
        }

        private void bt_watchEarnings_Click(object sender, EventArgs e)
        {
            FrmChiffreAffaire frm = new FrmChiffreAffaire(bd);
            frm.Show();
        }

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
    }
}
