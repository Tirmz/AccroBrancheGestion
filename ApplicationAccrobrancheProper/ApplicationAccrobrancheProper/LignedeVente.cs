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
    
    public partial class LignedeVente
    {
        public int idLignedeVente { get; set; }
        public int idVente { get; set; }
        public int idProduit { get; set; }
        public int quantiteVente { get; set; }
    
        public virtual Vente LaVente { get; set; }
        public virtual Produit LeProduit { get; set; }
    }
}
