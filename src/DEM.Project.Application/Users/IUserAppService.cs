using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DEM.Project.Roles.Dto;
using DEM.Project.Users.Dto;

namespace DEM.Project.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
