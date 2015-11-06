using System.Threading.Tasks;
using Abp.Application.Services;
using Ementor.Users.Dto;

namespace Ementor.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}