using AutoEF2022.Entidades;

namespace AutoEF2022.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class Marca
    {
        public Marca()
        {
            Autos = new HashSet<Auto>();
        }

        public int MarcaId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }



       
    }
}
