using Abp.Authorization.Roles;
using Ementor.MultiTenancy;
using Ementor.Users;

namespace Ementor.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}