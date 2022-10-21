using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class InsumosDA : BaseDapper<InsumosModel>
    {
        public InsumosDA() { }

        public InsumosDA(string conString) : base(conString) { }

        public InsumosDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
