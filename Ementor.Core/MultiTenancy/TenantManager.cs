using Abp.MultiTenancy;
using Ementor.Authorization.Roles;
using Ementor.Editions;
using Ementor.Users;

namespace Ementor.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(EditionManager editionManager)
            : base(editionManager)
        {

        }
    }
}