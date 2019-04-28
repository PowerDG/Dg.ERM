
using AutoMapper;
using DG.ERM.OrganizationStructure;
using DG.ERM.OrganizationStructure.Dtos;

namespace DG.ERM.OrganizationStructure.Mapper
{

	/// <summary>
    /// 配置DgOrganizationUnit的AutoMapper
    /// </summary>
	internal static class DgOrganizationUnitMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <DgOrganizationUnit,DgOrganizationUnitListDto>();
            configuration.CreateMap <DgOrganizationUnitListDto,DgOrganizationUnit>();

            configuration.CreateMap <DgOrganizationUnitEditDto,DgOrganizationUnit>();
            configuration.CreateMap <DgOrganizationUnit,DgOrganizationUnitEditDto>();

        }
	}
}
