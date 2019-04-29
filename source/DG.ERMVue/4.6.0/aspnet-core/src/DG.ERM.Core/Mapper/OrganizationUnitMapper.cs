
using AutoMapper;
using DG.ERM;
using DG.ERM.Dtos;

namespace DG.ERM.Mapper
{

	/// <summary>
    /// 配置OrganizationUnit的AutoMapper
    /// </summary>
	internal static class OrganizationUnitMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <OrganizationUnit,OrganizationUnitListDto>();
            configuration.CreateMap <OrganizationUnitListDto,OrganizationUnit>();

            configuration.CreateMap <OrganizationUnitEditDto,OrganizationUnit>();
            configuration.CreateMap <OrganizationUnit,OrganizationUnitEditDto>();

        }
	}
}
