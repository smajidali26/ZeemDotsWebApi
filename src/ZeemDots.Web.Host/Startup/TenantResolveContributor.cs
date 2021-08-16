using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.MultiTenancy;

namespace ZeemDots.Web.Host.Startup
{
    public class TenantResolveContributor : ITenantResolver
    {
        public int? ResolveTenantId()
        {
            throw new NotImplementedException();
        }
    }
}
