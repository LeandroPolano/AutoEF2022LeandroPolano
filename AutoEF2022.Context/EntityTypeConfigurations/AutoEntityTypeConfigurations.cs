using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoEF2022.Entidades;

namespace AutoEF2022.Context.EntityTypeConfigurations
{
    class AutoEntityTypeConfigurations:EntityTypeConfiguration<Auto>
    {
        public AutoEntityTypeConfigurations()
        {
            ToTable("TiposDeAutos");
            HasKey(a => a.AutoId);

            HasIndex(a => a.Modelo).IsUnique();
            Property(a => a.Modelo).IsRequired().HasMaxLength(20);

            HasIndex(a => a.TipoDeAuto).IsUnique();
            Property(a => a.TipoDeAuto).IsRequired().HasMaxLength(20);

            HasIndex(a => a.PaisDeOrigen).IsUnique();
            Property(a => a.PaisDeOrigen).IsRequired().HasMaxLength(50);
        }
    }
}
