using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Compras")]
    public class ComprasModel
    {

        //NECESARIO MODIFICAR EN RELACIÓN A LA TABLA PEDIDOS
        [ExplicitKey]
        public int ID_Compra { get; set; }
        public int Valor { get; set; }
        public int ID_Cliente {get; set;}
    }
}