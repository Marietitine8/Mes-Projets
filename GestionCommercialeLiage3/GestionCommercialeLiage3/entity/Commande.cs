namespace GestionCommercialeLiage3.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commande.Commande")]
    public partial class Commande
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Libelle { get; set; }

        public float? Qtecmd { get; set; }

        public float? Prix { get; set; }

        public float? Montant { get; set; }
    }
}
