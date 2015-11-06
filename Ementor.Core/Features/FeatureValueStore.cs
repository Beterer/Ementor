using Abp.Application.Features;
using Ementor.Authorization.Roles;
using Ementor.MultiTenancy;
using Ementor.Users;

namespace Ementor.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}