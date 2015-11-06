using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ementor.MultiTenancy;

namespace Ementor.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}