
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


using DG.ERM.DgOrganizationUnits;
using DG.ERM.DgOrganizationUnits.Dtos;
using DG.ERM.DgOrganizationUnits.DomainService;
using DG.ERM.DgOrganizationUnits.Authorization;


namespace DG.ERM.DgOrganizationUnits
{
    /// <summary>
    /// DgOrganizationUnit应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class DgOrganizationUnitAppService : ERMAppServiceBase, IDgOrganizationUnitAppService
    {
        private readonly IRepository<DgOrganizationUnit, int> _entityRepository;

        private readonly IDgOrganizationUnitManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public DgOrganizationUnitAppService(
        IRepository<DgOrganizationUnit, int> entityRepository
        ,IDgOrganizationUnitManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取DgOrganizationUnit的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(DgOrganizationUnitPermissions.Query)] 
        public async Task<PagedResultDto<DgOrganizationUnitListDto>> GetPaged(GetDgOrganizationUnitsInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<DgOrganizationUnitListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<DgOrganizationUnitListDto>>();

			return new PagedResultDto<DgOrganizationUnitListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取DgOrganizationUnitListDto信息
		/// </summary>
		[AbpAuthorize(DgOrganizationUnitPermissions.Query)] 
		public async Task<DgOrganizationUnitListDto> GetById(EntityDto<int> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<DgOrganizationUnitListDto>();
		}

		/// <summary>
		/// 获取编辑 DgOrganizationUnit
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(DgOrganizationUnitPermissions.Create,DgOrganizationUnitPermissions.Edit)]
		public async Task<GetDgOrganizationUnitForEditOutput> GetForEdit(NullableIdDto<int> input)
		{
			var output = new GetDgOrganizationUnitForEditOutput();
DgOrganizationUnitEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<DgOrganizationUnitEditDto>();

				//dgOrganizationUnitEditDto = ObjectMapper.Map<List<dgOrganizationUnitEditDto>>(entity);
			}
			else
			{
				editDto = new DgOrganizationUnitEditDto();
			}

			output.DgOrganizationUnit = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改DgOrganizationUnit的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(DgOrganizationUnitPermissions.Create,DgOrganizationUnitPermissions.Edit)]
		public async Task CreateOrUpdate(CreateOrUpdateDgOrganizationUnitInput input)
		{

			if (input.DgOrganizationUnit.Id.HasValue)
			{
				await Update(input.DgOrganizationUnit);
			}
			else
			{
				await Create(input.DgOrganizationUnit);
			}
		}


		/// <summary>
		/// 新增DgOrganizationUnit
		/// </summary>
		[AbpAuthorize(DgOrganizationUnitPermissions.Create)]
		protected virtual async Task<DgOrganizationUnitEditDto> Create(DgOrganizationUnitEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <DgOrganizationUnit>(input);
            var entity=input.MapTo<DgOrganizationUnit>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<DgOrganizationUnitEditDto>();
		}

		/// <summary>
		/// 编辑DgOrganizationUnit
		/// </summary>
		[AbpAuthorize(DgOrganizationUnitPermissions.Edit)]
		protected virtual async Task Update(DgOrganizationUnitEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除DgOrganizationUnit信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(DgOrganizationUnitPermissions.Delete)]
		public async Task Delete(EntityDto<int> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除DgOrganizationUnit的方法
		/// </summary>
		[AbpAuthorize(DgOrganizationUnitPermissions.BatchDelete)]
		public async Task BatchDelete(List<int> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出DgOrganizationUnit为excel表,等待开发。
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


