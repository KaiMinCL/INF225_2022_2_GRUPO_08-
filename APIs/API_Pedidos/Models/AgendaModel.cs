using Dapper.Contrib.Extensions;

namespace API.Models
{
    [Table("Agenda")]
    public class AgendaModel
    {

        //NECESARIO MODIFICAR EN RELACIÓN A LA TABLA PEDIDOS
        [ExplicitKey]
        public string? id { get; set; }
        public string? name { get; set; }
        public string? date {get;set;}
        public string? description {get;set;}
    }
}