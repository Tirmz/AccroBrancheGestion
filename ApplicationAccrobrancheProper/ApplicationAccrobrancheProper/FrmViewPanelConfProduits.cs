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
    public partial class FrmViewPanelConfProduits : Form
    {
        private Modele bd;
        public FrmViewPanelConfProduits(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.Produit.ToList();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmViewPanelConfProduits_Load(object sender, EventArgs e)
        {

        }
    }
}
