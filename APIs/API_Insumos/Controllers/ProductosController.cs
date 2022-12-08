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

        /// <summary>
        /// Obtiene todos los productos
        /// </summary>
        /// <param name="value">Informacion del tipo de documento</param>
        /// <returns></returns>
        /// <remarks>
        /// Aqui se puede indicar un ejemplo de como llamar este servicio
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpGet("")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ProductosModel>>> GetProducto() => await base.Get();

        /// <summary>
        /// Obtiene un producto según su ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value">Informacion del tipo de documento</param>
        /// <returns></returns>
        /// <remarks>
        /// Aqui se puede indicar un ejemplo de como llamar este servicio
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosModel>> GetProductoById(string id) => await base.GetById(id);

        /// <summary>
        /// Permite Agregar nuevos Productos
        /// </summary>
        /// <param name="value">Informacion del tipo de documento</param>
        /// <returns></returns>
        /// <remarks>
        /// Aqui se puede indicar un ejemplo de como llamar este servicio
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosModel>> PostProducto([FromBody]ProductosModel value) => await base.Post(value);

        /// <summary>
        /// Permite Modificar Productos
        /// </summary>
        /// <param name="value">Informacion del tipo de documento</param>
        /// <returns></returns>
        /// <remarks>
        /// Aqui se puede indicar un ejemplo de como llamar este servicio
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosModel>> PutProducto([FromBody]ProductosModel value) => await base.Put(value);

        /// <summary>
        /// Permite Eliminar un Producto según su ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value">Informacion del tipo de documento</param>
        /// <returns></returns>
        /// <remarks>
        /// Aqui se puede indicar un ejemplo de como llamar este servicio
        /// </remarks>
        /// <response code="200">Inserción correcta</response>

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductosModel>> DeleteProducto(string id) => await base.Delete(id);
    }
}