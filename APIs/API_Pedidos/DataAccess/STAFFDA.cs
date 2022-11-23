using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class STAFFDA : BaseDapper<STAFFModel>
    {
        public STAFFDA() { }

        public STAFFDA(string conString) : base(conString) { }

        public STAFFDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
