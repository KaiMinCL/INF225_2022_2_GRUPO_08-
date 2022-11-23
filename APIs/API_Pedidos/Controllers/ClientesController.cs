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
    public class ClientesController : BaseWebApiNoBusController<ClientesBusiness, ClientesModel>
    {
        public ClientesController(string conString, ILogger<ClientesController> logger) : base(conString, DataBaseType.SqlServer, new ClientesDA(), logger ) { }

        /// <summary>
        /// Si no se indica el Id del Cliente, se retornan todos los Clientes registrados
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>

        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ClientesModel>>> GetClientes() => await base.Get();

        /// <summary>
        /// Si se indica el Id del cliente, se retorna el cliente relacionado al respectivo id
        /// </summary>
        /// <param name="id">Identificador del Cliente</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: \
        ///                 curl -X 'GET' \
        ///                 'URL_API/Clientes/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Returns ...</response>

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ClientesModel>> GetClienteById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite crear nuevos clientes
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ClientesModel>> PostCliente([FromBody]ClientesModel value) => await base.Post(value);

        /// <summary>
        /// Permite modificar los clientes
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Actualización correcta</response>

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ClientesModel>> PutCliente([FromBody]ClientesModel value) => await base.Put(value);

        /// <summary>
        /// Permite eliminar clientes
        /// </summary>
        /// <param name="id">Identificador del Cliente</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: \
        ///                 curl -X 'DELETE' \
        ///                 'URL_API/Clientes/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Eliminación correcta</response>

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ClientesModel>> DeleteCliente(string id) => await base.Delete(id);
    }
}