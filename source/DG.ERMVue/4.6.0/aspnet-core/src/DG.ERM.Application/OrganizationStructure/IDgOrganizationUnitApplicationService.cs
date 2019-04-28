
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Authorization;
using Abp.Linq.Extensions;
using Abp.Domain.Repositories;
using Abp.Application.Services;
using Abp.Application.Services.Dto;


using DG.ERM.OrganizationStructure.Dtos;
using DG.ERM.OrganizationStructure;

namespace DG.ERM.OrganizationStructure
{
    /// <summary>
    /// DgOrganizationUnit应用层服务的接口方法
    ///</summary>
    public interface IDgOrganizationUnitAppService : IApplicationService
    {
        /// <summary>
		/// 获取DgOrganizationUnit的分页列表信息
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<DgOrganizationUnitListDto>> GetPaged(GetDgOrganizationUnitsInput input);


		/// <summary>
		/// 通过指定id获取DgOrganizationUnitListDto信息
		/// </summary>
		Task<DgOrganizationUnitListDto> GetById(EntityDto<int> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetDgOrganizationUnitForEditOutput> GetForEdit(NullableIdDto<int> input);


        /// <summary>
        /// 添加或者修改DgOrganizationUnit的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateDgOrganizationUnitInput input);


        /// <summary>
        /// 删除DgOrganizationUnit信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<int> input);


        /// <summary>
        /// 批量删除DgOrganizationUnit
        /// </summary>
        Task BatchDelete(List<int> input);


		/// <summary>
        /// 导出DgOrganizationUnit为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetToExcel();

    }
}
