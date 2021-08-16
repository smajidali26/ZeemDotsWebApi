using System.Threading.Tasks;
using Abp.Application.Services;
using ZeemDots.Sessions.Dto;

namespace ZeemDots.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
