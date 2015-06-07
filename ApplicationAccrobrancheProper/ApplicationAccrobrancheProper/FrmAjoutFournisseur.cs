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
    public partial class FrmAjoutFournisseur : Form
    {
        Modele bd;
        public FrmAjoutFournisseur(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
        }

        private void bt_validateAjout_Click(object sender, EventArgs e)
        {
            if (txt_namefour.Text != "" &&  txt_villefour.Text != "" && txt_cpfour.Text != "")
            {
                Fournisseur lefournisseur = new Fournisseur();
                lefournisseur.nomFournisseur = txt_namefour.Text;
                lefournisseur.villeFournisseur = txt_villefour.Text;
                lefournisseur.cpFournisseur = txt_villefour.Text;
                bd.Fournisseur.Add(lefournisseur);
                bd.SaveChanges();
                MessageBox.Show("Fournisseur Ajouté");
                this.Close();
            }
            else
            {
                MessageBox.Show("Un champ ou plusieurs sont vides");
            }
        }
    }
}
