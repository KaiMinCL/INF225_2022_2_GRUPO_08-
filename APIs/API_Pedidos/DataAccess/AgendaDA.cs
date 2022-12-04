using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class AgendaDA : BaseDapper<AgendaModel>
    {
        public AgendaDA() { }

        public AgendaDA(string conString) : base(conString) { }

        public AgendaDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
