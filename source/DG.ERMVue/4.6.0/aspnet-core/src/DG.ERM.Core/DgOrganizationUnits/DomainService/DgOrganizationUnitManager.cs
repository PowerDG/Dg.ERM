

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using DG.ERM;
using DG.ERM.DgOrganizationUnits;


namespace DG.ERM.DgOrganizationUnits.DomainService
{
    /// <summary>
    /// DgOrganizationUnit领域层的业务管理
    ///</summary>
    public class DgOrganizationUnitManager :ERMDomainServiceBase, IDgOrganizationUnitManager
    {
		
		private readonly IRepository<DgOrganizationUnit,int> _repository;

		/// <summary>
		/// DgOrganizationUnit的构造方法
		///</summary>
		public DgOrganizationUnitManager(
			IRepository<DgOrganizationUnit, int> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitDgOrganizationUnit()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
