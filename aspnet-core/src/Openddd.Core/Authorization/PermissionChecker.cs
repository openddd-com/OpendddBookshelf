using Abp.Authorization;
using Openddd.Authorization.Roles;
using Openddd.Authorization.Users;

namespace Openddd.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
