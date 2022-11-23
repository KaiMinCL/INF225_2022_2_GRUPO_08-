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
    public class InsumosDeProductoController : BaseWebApiNoBusController<InsumosDeProductoBusiness, InsumosDeProductoModel>
    {
        public InsumosDeProductoController(string conString, ILogger<InsumosDeProductoController> logger) : base(conString, DataBaseType.SqlServer, new InsumosDeProductoDA(), logger ) { }

        /// <summary>
        /// Obtiene todos los Insumos, si no se indican parámetros de consulta se retornan todos
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>
        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<InsumosDeProductoModel>>> GetInsumosDeProducto() => await base.Get();

        /// <summary>
        /// Obtiene Insumo a partir de su ID
        /// </summary>
        /// <param name="id">Identificador del color</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: TO DO
        /// </remarks>
        /// <response code="200">Returns ...</response>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<InsumosDeProductoModel>> GetInsumosDeProductoById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite crear nuevos Insumos
        /// </summary>
        /// <param name="value">Informacion del tipo de documento</param>
        /// <returns></returns>
        /// <remarks>
        /// Aqui se puede indicar un ejemplo de como llamar este servicio
        /// </remarks>
        /// <response code="200">Inserción correcta</response>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<InsumosDeProductoModel>> PostInsumosDeProducto([FromBody]InsumosDeProductoModel value) => await base.Post(value);

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<InsumosDeProductoModel>> PutIInsumosDeProducto([FromBody]InsumosDeProductoModel value) => await base.Put(value);

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<InsumosDeProductoModel>> DeleteInsumosDeProducto(string id) => await base.Delete(id);
    }
}