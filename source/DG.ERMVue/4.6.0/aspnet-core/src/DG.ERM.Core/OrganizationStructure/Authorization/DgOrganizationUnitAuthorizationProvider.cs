

using System.Linq;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using DG.ERM.Authorization;

namespace DG.ERM.OrganizationStructure.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="DgOrganizationUnitPermissions" /> for all permission names. DgOrganizationUnit
    ///</summary>
    public class DgOrganizationUnitAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public DgOrganizationUnitAuthorizationProvider()
		{

		}

        public DgOrganizationUnitAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public DgOrganizationUnitAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了DgOrganizationUnit 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(DgOrganizationUnitPermissions.Node , L("DgOrganizationUnit"));
			entityPermission.CreateChildPermission(DgOrganizationUnitPermissions.Query, L("QueryDgOrganizationUnit"));
			entityPermission.CreateChildPermission(DgOrganizationUnitPermissions.Create, L("CreateDgOrganizationUnit"));
			entityPermission.CreateChildPermission(DgOrganizationUnitPermissions.Edit, L("EditDgOrganizationUnit"));
			entityPermission.CreateChildPermission(DgOrganizationUnitPermissions.Delete, L("DeleteDgOrganizationUnit"));
			entityPermission.CreateChildPermission(DgOrganizationUnitPermissions.BatchDelete, L("BatchDeleteDgOrganizationUnit"));
			entityPermission.CreateChildPermission(DgOrganizationUnitPermissions.ExportExcel, L("ExportExcelDgOrganizationUnit"));


		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, ERMConsts.LocalizationSourceName);
		}
    }
}