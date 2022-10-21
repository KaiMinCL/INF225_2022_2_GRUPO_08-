using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.Extensions.Logging;
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
    public class ProductosController : BaseWebApiNoBusController<ProductosBusiness, ProductosModel>
    {
        public ProductosController(string conString, ILogger<ProductosController> logger) : base(conString, DataBaseType.SqlServer, new ProductosDA(), logger ) { }

        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ProductosModel>>> GetProducto() => await base.Get();

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosModel>> GetProductoById(string id) => await base.GetById(id);

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosModel>> PostProducto([FromBody]ProductosModel value) => await base.Post(value);

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosModel>> PutProducto([FromBody]ProductosModel value) => await base.Put(value);

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosModel>> DeleteProducto(string id) => await base.Delete(id);
    }
}