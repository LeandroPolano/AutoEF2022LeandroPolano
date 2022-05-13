using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoEF2022.Entidades;

namespace AutoEF2022.Context.EntityTypeConfigurations
{
    public class TipoDeAutoEntityTypeConfigurations:EntityTypeConfiguration<TipoDeAuto>
    {
        public TipoDeAutoEntityTypeConfigurations()
        {
            ToTable("TiposDeAutos");
            HasKey(ta => ta.TipoDeAutoId);
            HasIndex(ta => ta.Descripcion).IsUnique();
            Property(te => te.Descripcion).IsRequired().HasMaxLength(50);

        }


    }
}
