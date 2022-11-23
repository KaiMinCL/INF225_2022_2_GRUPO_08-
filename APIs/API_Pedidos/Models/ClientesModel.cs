using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Clientes")]
    public class ClientesModel
    {

        //NECESARIO MODIFICAR EN RELACIÓN A LA TABLA PEDIDOS
        [ExplicitKey]
        public int ID_Cliente { get; set; }
        public string? Nombre { get; set; }
        public string? RUT { get; set; }
        public string? Contrasena { get; set; }
    }
}