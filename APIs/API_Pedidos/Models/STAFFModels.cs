using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("STAFF")]
    public class STAFFModels
    {

        //NECESARIO MODIFICAR EN RELACIÓN A LA TABLA PEDIDOS
        [ExplicitKey]
        public int ID_STAFF { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int ID_Tienda {get; set;}
    }
}