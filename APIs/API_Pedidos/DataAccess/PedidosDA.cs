using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class PedidosDA : BaseDapper<PedidosModel>
    {
        public PedidosDA() { }

        public PedidosDA(string conString) : base(conString) { }

        public PedidosDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
