using System.Collections.Generic;
using DEM.Project.Roles.Dto;

namespace DEM.Project.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
