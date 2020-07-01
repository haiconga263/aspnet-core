using System.Threading.Tasks;
using DEM.Project.Configuration.Dto;

namespace DEM.Project.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
