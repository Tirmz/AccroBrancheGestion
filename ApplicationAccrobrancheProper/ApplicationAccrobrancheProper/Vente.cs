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
    
    public partial class Vente
    {
        public Vente()
        {
            this.LesLignesdeVentes = new List<LignedeVente>();
        }
    
        public int idVente { get; set; }
        public System.DateTime dateVente { get; set; }
    
        public virtual List<LignedeVente> LesLignesdeVentes { get; set; }

        public float GetTotalHT
        {
            get
            {
                float THT = 0;
                foreach (LignedeVente laligne in LesLignesdeVentes)
                {
                    THT += laligne.GetTotalHTLigneVente;
                }
                return (float)Math.Round(THT,2);
            }
        }
    }
}
