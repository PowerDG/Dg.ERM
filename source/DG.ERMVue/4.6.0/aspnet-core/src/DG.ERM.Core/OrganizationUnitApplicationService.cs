
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
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using DG.ERM;
using DG.ERM.Dtos;
using DG.ERM.DomainService;
using DG.ERM.Authorization;


namespace DG.ERM
{
    /// <summary>
    /// OrganizationUnit应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class OrganizationUnitAppService : ERMAppServiceBase, IOrganizationUnitAppService
    {
        private readonly IRepository<OrganizationUnit, long> _entityRepository;

        private readonly IOrganizationUnitManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public OrganizationUnitAppService(
        IRepository<OrganizationUnit, long> entityRepository
        ,IOrganizationUnitManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取OrganizationUnit的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(OrganizationUnitPermissions.Query)] 
        public async Task<PagedResultDto<OrganizationUnitListDto>> GetPaged(GetOrganizationUnitsInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<OrganizationUnitListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<OrganizationUnitListDto>>();

			return new PagedResultDto<OrganizationUnitListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取OrganizationUnitListDto信息
		/// </summary>
		[AbpAuthorize(OrganizationUnitPermissions.Query)] 
		public async Task<OrganizationUnitListDto> GetById(EntityDto<long> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<OrganizationUnitListDto>();
		}

		/// <summary>
		/// 获取编辑 OrganizationUnit
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(OrganizationUnitPermissions.Create,OrganizationUnitPermissions.Edit)]
		public async Task<GetOrganizationUnitForEditOutput> GetForEdit(NullableIdDto<long> input)
		{
			var output = new GetOrganizationUnitForEditOutput();
OrganizationUnitEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<OrganizationUnitEditDto>();

				//organizationUnitEditDto = ObjectMapper.Map<List<organizationUnitEditDto>>(entity);
			}
			else
			{
				editDto = new OrganizationUnitEditDto();
			}

			output.OrganizationUnit = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改OrganizationUnit的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(OrganizationUnitPermissions.Create,OrganizationUnitPermissions.Edit)]
		public async Task CreateOrUpdate(CreateOrUpdateOrganizationUnitInput input)
		{

			if (input.OrganizationUnit.Id.HasValue)
			{
				await Update(input.OrganizationUnit);
			}
			else
			{
				await Create(input.OrganizationUnit);
			}
		}


		/// <summary>
		/// 新增OrganizationUnit
		/// </summary>
		[AbpAuthorize(OrganizationUnitPermissions.Create)]
		protected virtual async Task<OrganizationUnitEditDto> Create(OrganizationUnitEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <OrganizationUnit>(input);
            var entity=input.MapTo<OrganizationUnit>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<OrganizationUnitEditDto>();
		}

		/// <summary>
		/// 编辑OrganizationUnit
		/// </summary>
		[AbpAuthorize(OrganizationUnitPermissions.Edit)]
		protected virtual async Task Update(OrganizationUnitEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除OrganizationUnit信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(OrganizationUnitPermissions.Delete)]
		public async Task Delete(EntityDto<long> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除OrganizationUnit的方法
		/// </summary>
		[AbpAuthorize(OrganizationUnitPermissions.BatchDelete)]
		public async Task BatchDelete(List<long> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出OrganizationUnit为excel表,等待开发。
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetToExcel()
		//{
		//	var users = await UserManager.Users.ToListAsync();
		//	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
		//	await FillRoleNames(userListDtos);
		//	return _userListExcelExporter.ExportToFile(userListDtos);
		//}

    }
}


