using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Insumos")]
    public class InsumosModel
    {
        [Key]
        public string? ID_Insumo { get; set; }
        public string? Nombre { get; set; }
        public int Stock { get; set; }
        public int Costo {get; set;}
        public int Precio {get;set;}
    }
}