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
    public class STAFFController : BaseWebApiNoBusController<STAFFBusiness, STAFFModel>
    {
        public STAFFController(string conString, ILogger<STAFFController> logger) : base(conString, DataBaseType.SqlServer, new STAFFDA(), logger ) { }

        /// <summary>
        /// Obtiene todos los Pedidos, si no se indican parámetros de consulta se retornan todos
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>
        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<STAFFModel>>> GetSTAFF() => await base.Get();

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
        public async Task<ActionResult<STAFFModel>> GetSTAFFById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite crear nuevos Pedidos
        /// </summary>
        /// <param name="value">Informacion del tipo de documento</param>
        /// <returns></returns>
        /// <remarks>
        /// Aqui se puede indicar un ejemplo de como llamar este servicio
        /// </remarks>
        /// <response code="200">Inserción correcta</response>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<STAFFModel>> PostSTAFF([FromBody]STAFFModel value) => await base.Post(value);

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<STAFFModel>> PutSTAFF([FromBody]STAFFModel value) => await base.Put(value);

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<STAFFModel>> DeleteSTAFF(string id) => await base.Delete(id);
    }
}