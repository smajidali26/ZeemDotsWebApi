using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Modules;
using Abp.MultiTenancy;
using Abp.Text;
using Abp.Zero;
using System.Web;
using Abp.Extensions;
using Microsoft.AspNetCore.Http;

namespace ZeemDots
{
    public class ZeemDotsTenantResolver : ITenantResolveContributor, ITransientDependency
    {
        private readonly ITenantStore _tenantStore;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ZeemDotsTenantResolver(ITenantStore tenantStore, IHttpContextAccessor httpContextAccessor)
        {
            _tenantStore = tenantStore;
            _httpContextAccessor = httpContextAccessor;
        }
        public int? ResolveTenantId()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
            {
                return null;
            }

            var hostName = httpContext.Request.Host.Host.RemovePreFix("http://", "https://").RemovePostFix("/");
            
            return null;
        }
    }
}
