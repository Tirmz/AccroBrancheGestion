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
    public partial class FrmVente : Form
    {
        private Modele bd;
        public FrmVente(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
        }

        private void FrmVente_Load(object sender, EventArgs e)
        {
            setDisplay();
        }

        /// <summary>
        /// Permet la mise en place des éléments dynamiques du formulaire
        /// </summary>
        private void setDisplay()
        {
            fillcbx(cbx_nameboisson, 1);
            fillcbx(cbx_namegateau, 2);
            fillcbx(cbx_nameglaces, 3);
            fillcbx(cbx_nameEquipments, 4);
        }

        /// <summary>
        /// Permet de remplir une combobox en spécifiant la catégorie du produit.
        /// </summary>
        private void fillcbx(ComboBox cbx, int categorie)
        {
            var fillcombobox = (from p in bd.Produit
                                where p.idCategorie.Equals(categorie)
                                select p);
            cbx.DataSource = fillcombobox.ToList();
            cbx.DisplayMember = "nomProduit";
            cbx.ValueMember = "idProduit";
        }

        private void bt_validateboisson_Click(object sender, EventArgs e)
        {
            lb_recapvente.Text = cbx_nameboisson.SelectedValue.ToString();
        }
    }
}
