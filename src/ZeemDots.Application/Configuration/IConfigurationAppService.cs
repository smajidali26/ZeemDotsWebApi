using System.Threading.Tasks;
using ZeemDots.Configuration.Dto;

namespace ZeemDots.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
