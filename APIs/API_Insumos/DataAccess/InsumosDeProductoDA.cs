using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class InsumosDeProductoDA : BaseDapper<InsumosDeProductoModel>
    {
        public InsumosDeProductoDA() { }

        public InsumosDeProductoDA(string conString) : base(conString) { }

        public InsumosDeProductoDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
