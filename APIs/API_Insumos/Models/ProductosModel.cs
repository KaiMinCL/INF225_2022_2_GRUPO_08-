using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Productos")]
    public class ProductosModel

    {
        [ExplicitKey]
        public string? ID_Producto { get; set; }
        public string? Nombre { get; set; }
        public int Stock { get; set; }
        public int Costo {get; set;}
        public int Precio {get;set;}
    }
}