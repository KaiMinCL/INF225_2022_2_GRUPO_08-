using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Pedidos")]
    public class PedidosModel
    {

        //NECESARIO MODIFICAR EN RELACIÓN A LA TABLA PEDIDOS
        [ExplicitKey]
        public string ID_Insumo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
    }
}