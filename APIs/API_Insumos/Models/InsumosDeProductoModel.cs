using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Productos")]
    public class InsumosDeProductoModel

    {
        [ExplicitKey]
        public string? ID_Producto { get; set; }
        public string? ID_Insumo { get; set; }
    }
}