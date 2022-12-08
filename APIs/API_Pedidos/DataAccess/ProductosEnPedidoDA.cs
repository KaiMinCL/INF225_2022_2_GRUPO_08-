using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class ProductosEnPedidoDA : BaseDapper<ProductosEnPedidoModel>
    {
        public ProductosEnPedidoDA() { }

        public ProductosEnPedidoDA(string conString) : base(conString) { }

        public ProductosEnPedidoDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
