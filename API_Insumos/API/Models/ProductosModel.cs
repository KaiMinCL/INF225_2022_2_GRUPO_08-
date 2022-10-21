using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Productos")]
    public class ProductosModel

    {
        [ExplicitKey]
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public bool Disponibilidad { get; set; }
    }
}