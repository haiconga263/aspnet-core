using System.Collections.Generic;
using DEM.Project.Roles.Dto;

namespace DEM.Project.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}