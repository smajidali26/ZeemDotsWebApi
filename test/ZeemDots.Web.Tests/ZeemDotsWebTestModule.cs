using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZeemDots.EntityFrameworkCore;
using ZeemDots.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ZeemDots.Web.Tests
{
    [DependsOn(
        typeof(ZeemDotsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ZeemDotsWebTestModule : AbpModule
    {
        public ZeemDotsWebTestModule(ZeemDotsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZeemDotsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ZeemDotsWebMvcModule).Assembly);
        }
    }
}