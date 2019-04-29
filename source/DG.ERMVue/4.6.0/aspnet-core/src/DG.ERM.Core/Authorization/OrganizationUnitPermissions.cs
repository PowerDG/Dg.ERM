

namespace DG.ERM.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="OrganizationUnitAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class OrganizationUnitPermissions
	{
		/// <summary>
		/// OrganizationUnit权限节点
		///</summary>
		public const string Node = "Pages.OrganizationUnit";

		/// <summary>
		/// OrganizationUnit查询授权
		///</summary>
		public const string Query = "Pages.OrganizationUnit.Query";

		/// <summary>
		/// OrganizationUnit创建权限
		///</summary>
		public const string Create = "Pages.OrganizationUnit.Create";

		/// <summary>
		/// OrganizationUnit修改权限
		///</summary>
		public const string Edit = "Pages.OrganizationUnit.Edit";

		/// <summary>
		/// OrganizationUnit删除权限
		///</summary>
		public const string Delete = "Pages.OrganizationUnit.Delete";

        /// <summary>
		/// OrganizationUnit批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.OrganizationUnit.BatchDelete";

		/// <summary>
		/// OrganizationUnit导出Excel
		///</summary>
		public const string ExportExcel="Pages.OrganizationUnit.ExportExcel";

		 
		 
         
    }

}

