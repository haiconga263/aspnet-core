using Abp.Application.Services;
using DEM.Project.MultiTenancy.Dto;

namespace DEM.Project.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

