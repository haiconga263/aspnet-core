using System.Threading.Tasks;
using Abp.Application.Services;
using DEM.Project.Sessions.Dto;

namespace DEM.Project.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
