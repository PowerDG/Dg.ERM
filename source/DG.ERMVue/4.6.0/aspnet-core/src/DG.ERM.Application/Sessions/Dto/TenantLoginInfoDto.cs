using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using DG.ERM.MultiTenancy;

namespace DG.ERM.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
