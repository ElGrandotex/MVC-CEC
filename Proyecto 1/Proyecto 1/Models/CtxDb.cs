using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Proyecto_1.Models
{
    public partial class CtxDb : DbContext
    {
        public CtxDb()
            : base("name=CtxDb")
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Categorias)
                .HasForeignKey(e => e.CategoriaId)
                .WillCascadeOnDelete(false);
        }
    }
}
