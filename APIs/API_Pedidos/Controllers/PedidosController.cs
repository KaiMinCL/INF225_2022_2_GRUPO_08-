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
    public class PedidosController : BaseWebApiNoBusController<PedidosBusiness, PedidosModel>
    {
        public PedidosController(string conString, ILogger<PedidosController> logger) : base(conString, DataBaseType.SqlServer, new PedidosDA(), logger ) { }

        /// <summary>
        /// Si no se indica el Id del pedido, se retornan todos los pedidos registrados
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>
        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<PedidosModel>>> GetPedidos() => await base.Get();

        /// <summary>
        /// Si se indica el Id del pedido, se retorna el pedido relacionado al respectivo id
        /// </summary>
        /// <param name="id">Identificador del Pedido</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: curl -X 'GET' \
        ///                 'URL_API/Pedidos/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Returns ...</response>

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<PedidosModel>> GetPedidoById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite crear nuevos pedidos
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<PedidosModel>> PostPedido([FromBody]PedidosModel value) => await base.Post(value);

        /// <summary>
        /// Permite modificar los pedidos
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Actualización correcta</response>

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<PedidosModel>> PutPedido([FromBody]PedidosModel value) => await base.Put(value);

        /// <summary>
        /// Permite eliminar pedidos
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
        public async Task<ActionResult<PedidosModel>> DeletePedido(string id) => await base.Delete(id);
    }
}