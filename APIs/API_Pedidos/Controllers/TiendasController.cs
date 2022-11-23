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
    public class TiendasController : BaseWebApiNoBusController<TiendasBusiness, TiendasModel>
    {
        public TiendasController(string conString, ILogger<TiendasController> logger) : base(conString, DataBaseType.SqlServer, new TiendasDA(), logger ) { }

        /// <summary>
        /// Si no se indica el Id de la tienda, se retornan todas las tiendas
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>

        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<TiendasModel>>> GetTiendas() => await base.Get();

        /// <summary>
        /// Si se indica el Id de la tienda, se retorna la tienda relacionado al respectivo id
        /// </summary>
        /// <param name="id">Identificador de la tienda</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: 
        ///                 curl -X 'GET' \
        ///                 'URL_API/Tiendas/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Returns ...</response>

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<TiendasModel>> GetTiendasById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite crear nuevas tiendas
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<TiendasModel>> PostTienda([FromBody]TiendasModel value) => await base.Post(value);

        /// <summary>
        /// Permite modificar las tiendas
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Actualización correcta</response>

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<TiendasModel>> PutTienda([FromBody]TiendasModel value) => await base.Put(value);

        /// <summary>
        /// Permite eliminar tiendas
        /// </summary>
        /// <param name="id">Identificador de la tienda</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: 
        ///                 curl -X 'DELETE' \
        ///                 'URL_API/Tiendas/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Eliminación correcta</response>


        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<TiendasModel>> DeleteTienda(string id) => await base.Delete(id);
    }
}