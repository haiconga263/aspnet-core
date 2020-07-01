using Abp.Authorization;
using DEM.Project.Authorization.Roles;
using DEM.Project.Authorization.Users;

namespace DEM.Project.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
