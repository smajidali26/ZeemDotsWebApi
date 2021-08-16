using Abp.Application.Services;
using ZeemDots.MultiTenancy.Dto;

namespace ZeemDots.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

