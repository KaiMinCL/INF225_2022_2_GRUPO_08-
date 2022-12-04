using Microsoft.AspNetCore.Mvc;
using System.Net;
using API.Business;
using API.DataAccess;
using API.Models;
using Transversal.Util.Controller;
using static Transversal.Util.BaseDapper.BaseDapperGeneric;

namespace API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class AgendaController : BaseWebApiNoBusController<AgendaBusiness, AgendaModel>
    {
        public AgendaController(string conString, ILogger<AgendaController> logger) : base(conString, DataBaseType.SqlServer, new AgendaDA(), logger ) { }

        /// <summary>
        /// Se obtienen todos los pedidos para la agenda
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>
        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<AgendaModel>>> GetAgenda() => await base.Get();

        /// <summary>
        /// Permite obtener información de la agenda de un pedido en particular
        /// </summary>
        /// <param name="id">Identificador del Pedido</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: curl -X 'GET' \
        ///                 'URL_API/Pedidos/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Returns ...</response>

        //[HttpGet("")]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //public async Task<ActionResult<AgendaModel>> GetAgendaById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite agregar pedidos a la agenda
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<AgendaModel>> PostAgenda([FromBody]AgendaModel value) => await base.Post(value);

        /// <summary>
        /// Permite modificar pedidos de la agenda
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Actualización correcta</response>

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<AgendaModel>> PutAgenda([FromBody]AgendaModel value) => await base.Put(value);

        /// <summary>
        /// Permite eliminar pedidos de la agenda
        /// </summary>
        /// <param name="id">Identificador del Pedido</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: curl -X 'DELETE' \
        ///                 'URL_API/Pedidos/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Eliminación correcta</response>

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<AgendaModel>> DeleteAgenda(string id) => await base.Delete(id);
    }
}