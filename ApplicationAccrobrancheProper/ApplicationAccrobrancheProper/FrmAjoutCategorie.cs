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
    public partial class FrmAjoutCategorie : Form
    {
        Modele bd;
        public FrmAjoutCategorie(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
        }

        private void bt_validateAjout_Click(object sender, EventArgs e)
        {
            if (txt_nameCategorie.Text != "")
            {
                Categorie lacategorie = new Categorie();
                lacategorie.libelleCategorie = txt_nameCategorie.Text;
                bd.Categorie.Add(lacategorie);
                bd.SaveChanges();
                MessageBox.Show("Catégorie Ajoutée");
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez préciser un nom de Catégorie");
            }
        }
    }
}
