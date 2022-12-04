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
    public class AgendaBusiness : BaseNoBusBusiness<AgendaModel>
    {
        public AgendaBusiness() : base() { }

        public AgendaBusiness(string Configuration) : base(Configuration, DataBaseType.SqlServer, new AgendaDA()) { }
    }
}
