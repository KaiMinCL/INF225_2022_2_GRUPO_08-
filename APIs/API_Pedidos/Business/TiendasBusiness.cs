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
    public class TiendasBusiness : BaseNoBusBusiness<TiendasModel>
    {
        public TiendasBusiness() : base() { }

        public TiendasBusiness(string Configuration) : base(Configuration, DataBaseType.SqlServer, new TiendasDA()) { }
    }
}
