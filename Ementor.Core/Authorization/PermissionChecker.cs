using Abp.Authorization;
using Ementor.Authorization.Roles;
using Ementor.MultiTenancy;
using Ementor.Users;

namespace Ementor.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
