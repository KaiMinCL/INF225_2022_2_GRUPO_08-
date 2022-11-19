using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Tiendas")]
    public class TiendasModel
    {

        //NECESARIO MODIFICAR EN RELACIÓN A LA TABLA PEDIDOS
        [ExplicitKey]
        public int ID_Tienda { get; set; }
        public string Nombre { get; set; }
        public string Instagram { get; set; }
    }
}