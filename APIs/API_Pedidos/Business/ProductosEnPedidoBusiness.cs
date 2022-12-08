using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.Negocio;
using static Transversal.Util.BaseDapper.BaseDapperGeneric;
using API.Models;
using API.DataAccess;


namespace API.Business
{
    public class ProductosEnPedidoBusiness : BaseNoBusBusiness<ProductosEnPedidoModel>
    {
        public ProductosEnPedidoBusiness() : base() { }

        public ProductosEnPedidoBusiness(string Configuration) : base(Configuration, DataBaseType.SqlServer, new ProductosEnPedidoDA()) { }
    }
}
