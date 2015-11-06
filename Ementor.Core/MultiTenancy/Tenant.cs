using Abp.MultiTenancy;
using Ementor.Users;

namespace Ementor.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}