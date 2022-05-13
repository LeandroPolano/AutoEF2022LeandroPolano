using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoEF2022.Context;

namespace AutoEF2022.Entidades
{
    [Table("Autos")]
    public partial class Auto
    {
        public int AutoId { get; set; }

        public int MarcaId { get; set; }

        public int TipoDeAutoId { get; set; }
        public string Modelo { get; set; }

       
        public string TipoDeAuto { get; set; }

        public decimal Precio { get; set; }

       
        public string PaisDeOrigen { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
