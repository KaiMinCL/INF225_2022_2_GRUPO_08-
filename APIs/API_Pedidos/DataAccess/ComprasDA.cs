using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class ComprasDA : BaseDapper<ComprasModel>
    {
        public ComprasDA() { }

        public ComprasDA(string conString) : base(conString) { }

        public ComprasDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
