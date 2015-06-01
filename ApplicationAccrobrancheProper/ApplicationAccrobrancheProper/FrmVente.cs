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
        private BindingList<LignedeVente> listelignes = new BindingList<LignedeVente>();
        
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

            dg_recapVente.DataSource = listelignes;
            setColumns();
        }

        /// <summary>
        /// Permet de remplir une combobox en spécifiant la catégorie du produit.
        /// </summary>
        private void fillcbx(ComboBox cbx, int categorie)
        {
            // Requête LINQ permettant de lister les produits en fonction de la catégorie.
            var fillcombobox = (from p in bd.Produit
                                where p.idCategorie.Equals(categorie)
                                select p);
            cbx.DataSource = fillcombobox.ToList();
            cbx.DisplayMember = "nomProduit";
            cbx.ValueMember = "idProduit";
        }

        private void bt_validateboisson_Click(object sender, EventArgs e)
        {
           LignedeVente nouvelleligne = new LignedeVente();
            nouvelleligne.idProduit = Convert.ToInt32(cbx_nameboisson.SelectedValue);
            nouvelleligne.quantiteVente = Convert.ToInt32(num_boissons.Value);

            nouvelleligne.LeProduit = (from p in bd.Produit
                                       where p.idProduit == nouvelleligne.idProduit
                                       select p).Single();
            listelignes.Add(nouvelleligne);
        }
        private void setColumns()
        {
            dg_recapVente.Columns["idLignedeVente"].DisplayIndex = 0;
            dg_recapVente.Columns["idVente"].DisplayIndex = 1;
            dg_recapVente.Columns["idProduit"].DisplayIndex = 2;
            dg_recapVente.Columns["GetNomProduit"].DisplayIndex = 3;
            dg_recapVente.Columns["quantiteVente"].DisplayIndex = 4;
            dg_recapVente.Columns["LaVente"].DisplayIndex = 5;
            dg_recapVente.Columns["LeProduit"].DisplayIndex = 6;
            dg_recapVente.Columns["GetPrixUnitaire"].DisplayIndex = 7;
            dg_recapVente.Columns["GetDateVente"].DisplayIndex = 8;
            dg_recapVente.Columns["GetTotalHTLigneVente"].DisplayIndex = 9;

            dg_recapVente.Columns["idLignedeVente"].Visible = false;
            dg_recapVente.Columns["idVente"].Visible = false;
            dg_recapVente.Columns["LaVente"].Visible = false;
            dg_recapVente.Columns["LeProduit"].Visible = false;
            dg_recapVente.Columns["GetDateVente"].Visible = false;

            dg_recapVente.Columns["idProduit"].HeaderText = "Référence";
            dg_recapVente.Columns["GetNomProduit"].HeaderText = "Produit";
            dg_recapVente.Columns["quantiteVente"].HeaderText = "Quantité";
            dg_recapVente.Columns["GetPrixUnitaire"].HeaderText = "Prix Unitaire";
            dg_recapVente.Columns["GetTotalHTLigneVente"].HeaderText = "Total";
        }

        private void bt_validatevente_Click(object sender, EventArgs e)
        {
            Vente lanouvellevente = new Vente();
            lanouvellevente.dateVente = DateTime.Now;

            bd.Vente.Add(lanouvellevente);
            bd.SaveChanges();

            foreach (LignedeVente ligne in listelignes)
            {
                ligne.idVente = lanouvellevente.idVente;
                bd.LignedeVente.Add(ligne);
            }
            bd.SaveChanges();

        }
    }
}
