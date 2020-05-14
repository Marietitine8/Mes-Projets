namespace GestionCommercialeLiage3.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGesCom : DbContext
    {
        public ModelGesCom()
            : base("name=ModelGesCom")
        {
        }

        public virtual DbSet<Commande> Commande { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
