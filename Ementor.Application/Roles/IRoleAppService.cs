using System.Threading.Tasks;
using Abp.Application.Services;
using Ementor.Roles.Dto;

namespace Ementor.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
