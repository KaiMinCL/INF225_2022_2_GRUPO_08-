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
    public class ComprasController : BaseWebApiNoBusController<ComprasBusiness, ComprasModel>
    {
        public ComprasController(string conString, ILogger<ComprasController> logger) : base(conString, DataBaseType.SqlServer, new ComprasDA(), logger ) { }

        /// <summary>
        /// Si no se indica el Id de la compra, se retornan todas las compras
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>
        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ComprasModel>>> GetCompras() => await base.Get();

        /// <summary>
        /// Si se indica el Id de la compra, se retornan la compra relacionada al respectivo id
        /// </summary>
        /// <param name="id">Identificador de la compra</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: curl -X 'GET' \
        ///                 'URL_API/Compras/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Returns ...</response>

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ComprasModel>> GetComprasbyID(string id) => await base.GetById(id);

        /// <summary>
        /// Permite crear nuevas compras
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Inserción correcta</response>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ComprasModel>> PostCompra([FromBody]ComprasModel value) => await base.Post(value);

                /// <summary>
        /// Permite modificar las compras
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Actualización correcta</response>

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ComprasModel>> PutCompra([FromBody]ComprasModel value) => await base.Put(value);

        /// <summary>
        /// Permite eliminar compras
        /// </summary>
        /// <param name="id">Identificador de la compra</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: curl -X 'DELETE' \
        ///                 'URL_API/Compras/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Eliminación correcta</response>

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ComprasModel>> DeleteCompra(string id) => await base.Delete(id);
    }
}