using System.Threading.Tasks;
using Abp.Application.Services;
using DEM.Project.Authorization.Accounts.Dto;

namespace DEM.Project.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
