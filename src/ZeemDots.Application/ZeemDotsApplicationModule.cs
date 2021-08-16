using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZeemDots.Authorization;

namespace ZeemDots
{
    [DependsOn(
        typeof(ZeemDotsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZeemDotsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ZeemDotsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ZeemDotsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
