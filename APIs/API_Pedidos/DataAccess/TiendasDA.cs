using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class TiendasDA : BaseDapper<TiendasModel>
    {
        public TiendasDA() { }

        public TiendasDA(string conString) : base(conString) { }

        public TiendasDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
