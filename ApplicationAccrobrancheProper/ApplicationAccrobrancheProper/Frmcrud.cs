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
            produitBindingSource.DataSource = bd.Produit.ToList();
        }

        private void Frmcrud_Load(object sender, EventArgs e)
        {
            var req = (from p in bd.Produit
                       where p.idProduit.Equals(idCategorieComboBox.SelectedValue.ToString())
                       select p.idProduit);
            idCategorieComboBox.DataSource = bd.Categorie.ToList();
            idCategorieComboBox.DisplayMember = "libelleCategorie";
            idCategorieComboBox.ValueMember = "idCategorie";
        }
    }
}
