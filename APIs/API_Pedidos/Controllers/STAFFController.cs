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
        /// Si no se indica el Id del STAFF, se retornan todos los STAFFs registrados
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns ...</response>

        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<STAFFModel>>> GetSTAFF() => await base.Get();

        /// <summary>
        /// Si se indica el Id del STAFF, se retorna el STAFF relacionado al respectivo id
        /// </summary>
        /// <param name="id">Identificador del STAFF</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: curl -X 'GET' \
        ///                 'URL_API/STAFF/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Returns ...</response>

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<STAFFModel>> GetSTAFFById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite crear nuevos miembros del STAFF
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<STAFFModel>> PostSTAFF([FromBody]STAFFModel value) => await base.Post(value);

        /// <summary>
        /// Permite modificar miembros del STAFF
        /// </summary>
        /// <param name="value">Body de Solicitud</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: ...
        /// </remarks>
        /// <response code="200">Actualización correcta</response>

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<STAFFModel>> PutSTAFF([FromBody]STAFFModel value) => await base.Put(value);

        /// <summary>
        /// Permite eliminar miembros del STAFF
        /// </summary>
        /// <param name="id">Identificador del STAFF</param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request: curl -X 'DELETE' \
        ///                 'URL_API/STAFF/{ID}' \
        ///                 -H 'accept: application/json'
        /// </remarks>
        /// <response code="200">Eliminación correcta</response>

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<STAFFModel>> DeleteSTAFF(string id) => await base.Delete(id);
    }
}