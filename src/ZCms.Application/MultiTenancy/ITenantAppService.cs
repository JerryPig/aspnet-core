using Abp.Application.Services;
using ZCms.MultiTenancy.Dto;

namespace ZCms.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

