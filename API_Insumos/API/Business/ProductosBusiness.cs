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
    public class ProductosBusiness : BaseNoBusBusiness<ProductosModel>
    {
        public ProductosBusiness() : base() { }

        public ProductosBusiness(string Configuration) : base(Configuration, DataBaseType.SqlServer, new ProductosDA()) { }
    }
}
