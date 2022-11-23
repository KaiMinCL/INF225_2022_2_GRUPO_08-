using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Util.BaseDapper;
using API.Models;

namespace API.DataAccess
{
    public class ClientesDA : BaseDapper<ClientesModel>
    {
        public ClientesDA() { }

        public ClientesDA(string conString) : base(conString) { }

        public ClientesDA(string conString, BaseDapperGeneric.DataBaseType motor) : base(conString, motor) { }
    }
}
