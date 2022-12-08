using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("ProductosEnPedido")]
    public class ProductosEnPedidoModel
    {

        //NECESARIO MODIFICAR EN RELACIÓN A LA TABLA PEDIDOS
        [ExplicitKey]
        public int ID_Pedido { get; set; }
        public int ID_Producto { get; set; }
    }
}