using System.Collections.Generic;
using DEM.Project.Roles.Dto;

namespace DEM.Project.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
