using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using ZeemDots.Authorization.Roles;
using ZeemDots.Authorization.Users;
using ZeemDots.Configuration;
using ZeemDots.Localization;
using ZeemDots.MultiTenancy;
using ZeemDots.Timing;

namespace ZeemDots
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ZeemDotsCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            ZeemDotsLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = ZeemDotsConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZeemDotsCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
