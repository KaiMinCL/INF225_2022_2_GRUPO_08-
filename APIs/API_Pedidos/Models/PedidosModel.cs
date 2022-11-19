using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Pedidos")]
    public class PedidosModel
    {

        //NECESARIO MODIFICAR EN RELACIÓN A LA TABLA PEDIDOS
        [ExplicitKey]
        public int ID_Pedido { get; set; }
        public int Valor { get; set; }
        public int ID_Tienda { get; set; }
    }
}