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
    public partial class FrmModifCategorie : Form
    {
       private Modele bd;
       private Categorie categoriemodifiee;
       public FrmModifCategorie(Modele p_bd, Categorie categorie)
        {
            InitializeComponent();
            bd = p_bd;
            categoriemodifiee = categorie;
            txt_nameCategorie.Text = categoriemodifiee.libelleCategorie;
        }

       private void bt_validateModif_Click(object sender, EventArgs e)
       {
           categoriemodifiee.libelleCategorie = txt_nameCategorie.Text;
           bd.Entry(categoriemodifiee).State = EntityState.Modified;
           bd.SaveChanges();
           MessageBox.Show("Catégorie modifiée");
           this.Close();
       }
    }
}
