using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ZeemDots.Configuration.Dto;

namespace ZeemDots.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ZeemDotsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
