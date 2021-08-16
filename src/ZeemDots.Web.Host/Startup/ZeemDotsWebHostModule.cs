using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZeemDots.Configuration;

namespace ZeemDots.Web.Host.Startup
{
    [DependsOn(
       typeof(ZeemDotsWebCoreModule))]
    public class ZeemDotsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ZeemDotsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZeemDotsWebHostModule).GetAssembly());
        }
    }
}
