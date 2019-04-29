

using System.Linq;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using DG.ERM.Authorization;

namespace DG.ERM.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="OrganizationUnitPermissions" /> for all permission names. OrganizationUnit
    ///</summary>
    public class OrganizationUnitAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public OrganizationUnitAuthorizationProvider()
		{

		}

        public OrganizationUnitAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public OrganizationUnitAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了OrganizationUnit 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(OrganizationUnitPermissions.Node , L("OrganizationUnit"));
			entityPermission.CreateChildPermission(OrganizationUnitPermissions.Query, L("QueryOrganizationUnit"));
			entityPermission.CreateChildPermission(OrganizationUnitPermissions.Create, L("CreateOrganizationUnit"));
			entityPermission.CreateChildPermission(OrganizationUnitPermissions.Edit, L("EditOrganizationUnit"));
			entityPermission.CreateChildPermission(OrganizationUnitPermissions.Delete, L("DeleteOrganizationUnit"));
			entityPermission.CreateChildPermission(OrganizationUnitPermissions.BatchDelete, L("BatchDeleteOrganizationUnit"));
			entityPermission.CreateChildPermission(OrganizationUnitPermissions.ExportExcel, L("ExportExcelOrganizationUnit"));


		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, ERMConsts.LocalizationSourceName);
		}
    }
}