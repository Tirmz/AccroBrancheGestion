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
        private BindingList<LignedeVente> listelignes = new BindingList<LignedeVente>(); //Liste qui permet regrouper toutes les lignes de ventes.
        
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
        public void fillcbx(ComboBox cbx, int categorie)
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
            addProductType(cbx_nameboisson, num_boissons);
        }
        private void bt_validategateau_Click(object sender, EventArgs e)
        {
            addProductType(cbx_namegateau, num_gateaux);
        }
        private void bt_validateglace_Click(object sender, EventArgs e)
        {
            addProductType(cbx_nameglaces, num_glaces);
        }
        private void bt_validateequipments_Click(object sender, EventArgs e)
        {
            addProductType(cbx_nameEquipments, num_equipments);
        }

        /// <summary>
        /// Permet d'ajouter un produit au dg_recapVente (listelignes), prends en paramètre un combobox et un numericUpDown.
        /// </summary>
        private void addProductType(ComboBox cbxproduit, NumericUpDown quantiteproduit)
        {
            if (quantiteproduit.Value != 0)
            {
                LignedeVente nouvelleligne = new LignedeVente();
                nouvelleligne.idProduit = Convert.ToInt32(cbxproduit.SelectedValue);
                nouvelleligne.quantiteVente = Convert.ToInt32(quantiteproduit.Value);

                nouvelleligne.LeProduit = (from p in bd.Produit
                                           where p.idProduit == nouvelleligne.idProduit
                                           select p).Single();
                listelignes.Add(nouvelleligne);
                // remet les valeurs par defaut
                cbxproduit.SelectedValue = 1;
                quantiteproduit.Value = 0;
            }
            else
            {
                MessageBox.Show("Vous devez spécifier la quantité");
            }
        }
        /// <summary>
        /// Prépare l'ordre des colonnes, cache les colonnes inutiles, renomme les colonnes pour des noms plus clairs
        /// </summary>
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
            dg_recapVente.Columns["getPrixTTC"].DisplayIndex = 9;
            dg_recapVente.Columns["GetTotalHTLigneVente"].DisplayIndex = 10;
            dg_recapVente.Columns["GetTotalTTCLigneVente"].DisplayIndex = 11;

            dg_recapVente.Columns["idLignedeVente"].Visible = false;
            dg_recapVente.Columns["idVente"].Visible = false;
            dg_recapVente.Columns["LaVente"].Visible = false;
            dg_recapVente.Columns["LeProduit"].Visible = false;
            dg_recapVente.Columns["GetDateVente"].Visible = false;

            dg_recapVente.Columns["idProduit"].HeaderText = "Référence";
            dg_recapVente.Columns["GetNomProduit"].HeaderText = "Produit";
            dg_recapVente.Columns["quantiteVente"].HeaderText = "Quantité";
            dg_recapVente.Columns["GetPrixUnitaire"].HeaderText = "Prix Unitaire HT";
            dg_recapVente.Columns["getPrixTTC"].HeaderText = "Prix Unitaire TTC";
            dg_recapVente.Columns["GetTotalHTLigneVente"].HeaderText = "Total HT";
            dg_recapVente.Columns["GetTotalTTCLigneVente"].HeaderText = "Total TTC";
        }

        /// <summary>
        /// Créé une nouvelle vente et Ajoute les produits sélectionnées à la vente.
        /// </summary>
        private void bt_validatevente_Click(object sender, EventArgs e)
        {
            try
            {
                if (listelignes.Count != 0) // Il ya des lignes de ventes dans la liste listelignes
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
                    MessageBox.Show("Vente Enregistrée");
                    listelignes.Clear();
                }
                else // Pas de ligne de ventes
                {
                    MessageBox.Show("Le vente ne contient aucun produit");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Stock pas assez Approvisionné");            
            }
        }
    }
}
