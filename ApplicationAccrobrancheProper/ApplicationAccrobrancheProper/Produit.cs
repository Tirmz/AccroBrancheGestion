//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationAccrobrancheProper
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit
    {
        public Produit()
        {
            this.LesLignesdeVentes = new List<LignedeVente>();
        }
    
        public int idProduit { get; set; }
        public string nomProduit { get; set; }
        public float prixProduitHT { get; set; }
        public int quantiteStockProduit { get; set; }
        public int StockAlert { get; set; }
        public int idCategorie { get; set; }
        public int idFournisseur { get; set; }
    
        public virtual Categorie LaCategorie { get; set; }
        public virtual Fournisseur LeFournisseur { get; set; }
        public virtual List<LignedeVente> LesLignesdeVentes { get; set; }

        #region Accesseur pour Adaptation des DataGridView
        public string GetCategorie
        {
            get { return LaCategorie.libelleCategorie; }
        }
        public string GetFournisseur
        {
            get { return LeFournisseur.nomFournisseur; }
        }
        public float GetPrixTCC
        {
            get
            {
                // La fonction Math.Round permet d'arrondir ce qu'on lui donne en paramètre lui spécifiant le nombre après la virgule ex : Math.Round(1.555, 2)
                return  (float)Math.Round((float)this.prixProduitHT * (float)1.20, 2);
            }
        }
        #endregion
    }
}
