using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using AutoEF2022.Entidades;

namespace AutoEF2022.Context
{
    public partial class AutoDbContext : DbContext
    {
        public AutoDbContext()
            : base("name=AutoDbContext")
        {
        }

        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Autos)
                .WithRequired(e => e.Marca)
                .WillCascadeOnDelete(false);
        }
    }
}
