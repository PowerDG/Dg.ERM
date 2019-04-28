using Abp.Authorization;
using DG.ERM.Authorization.Roles;
using DG.ERM.Authorization.Users;

namespace DG.ERM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
