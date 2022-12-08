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
    public class ProductosEnPedidoController : BaseWebApiNoBusController<ProductosEnPedidoBusiness, ProductosEnPedidoModel>
    {
        public ProductosEnPedidoController(string conString, ILogger<ProductosEnPedidoController> logger) : base(conString, DataBaseType.SqlServer, new ProductosEnPedidoDA(), logger ) { }

        /// <summary>
        /// Si no se indica el Id del pedido, se retornan todos los pedidos registrados
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>
        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ProductosEnPedidoModel>>> GetProductosEnPedido() => await base.Get();

        /// <summary>
        /// Si se indica el Id del pedido, se retorna todos los productos en ese pedido
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
        public async Task<ActionResult<ProductosEnPedidoModel>> GetProductosEnPedidoById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite agregar nuevos productos a un pedido
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosEnPedidoModel>> PostProductosEnPedido([FromBody]ProductosEnPedidoModel value) => await base.Post(value);

        /// <summary>
        /// Permite modificar el pedido del producto
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Actualización correcta</response>

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosEnPedidoModel>> PutProductosEnPedido([FromBody]ProductosEnPedidoModel value) => await base.Put(value);

        /// <summary>
        /// Permite eliminar productos de un pedido si se le indica el ID del pedido
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
        public async Task<ActionResult<ProductosEnPedidoModel>> DeleteProductosEnPedido(string id) => await base.Delete(id);
    }
}