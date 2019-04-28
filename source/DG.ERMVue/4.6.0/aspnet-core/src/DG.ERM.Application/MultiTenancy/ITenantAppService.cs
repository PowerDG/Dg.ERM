using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DG.ERM.MultiTenancy.Dto;

namespace DG.ERM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

