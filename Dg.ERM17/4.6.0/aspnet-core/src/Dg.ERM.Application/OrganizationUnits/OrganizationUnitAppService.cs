using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abp.UI;
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;
using Abp.AutoMapper;
using Abp.Domain.Uow;
using DG.ERM.Products;
using DG.ERM.Products.DomainService;
using Abp.Organizations;

namespace Dg.ERM.OrganizationUnits
{
   public class OrganizationUnitAppService : ERMAppServiceBase
    {

        private readonly IRepository<OrganizationUnit, long> _entityRepository;

        private readonly IProductManager _entityManager2;

        private readonly OrganizationUnitManager _entityManager;

        public OrganizationUnitAppService(
        IRepository<OrganizationUnit, long> entityRepository
        , OrganizationUnitManager entityManager
        )
        {
            _entityRepository = entityRepository;
            _entityManager = entityManager;
        }



        #region CRUD
        [UnitOfWork]
        public   async Task CreateAsync(OrganizationUnit organizationUnit)
        { 
            await _entityManager.CreateAsync(organizationUnit);
        }
        public   async Task UpdateAsync(OrganizationUnit organizationUnit)
        { 
            await _entityManager.UpdateAsync(organizationUnit); 
        }
        public async Task<string> GetNextChildCodeAsync(long? parentId)
        {

            var Ou = await _entityManager.GetNextChildCodeAsync(parentId);
            //var lastChild = await GetLastChildOrNullAsync(parentId);
            //if (lastChild == null)
            //{
            //    var parentCode = parentId != null ? await GetCodeAsync(parentId.Value) : null;
            //    return OrganizationUnit.AppendCode(parentCode, OrganizationUnit.CreateCode(1));
            //}

            //return OrganizationUnit.CalculateNextCode(lastChild.Code);
            if (Ou != null)
            {
                return Ou;
            }
            return null;
        }


        public virtual async Task<OrganizationUnit> GetLastChildOrNullAsync(long? parentId)
        {
            var Ou  = await _entityManager.GetLastChildOrNullAsync(parentId);
            if (Ou!=null)
            {
                return Ou;
            }
            return null;
            //var children = await OrganizationUnitRepository.GetAllListAsync(ou => ou.ParentId == parentId);
            //return children.OrderBy(c => c.Code).LastOrDefault();
        }


        public   async Task<string> GetCodeAsync(long id)
        {
            //return (await OrganizationUnitRepository.GetAsync(id)).Code;
            return await ( _entityManager.GetCodeAsync(id)); 
        }
        [UnitOfWork]
        public   async Task DeleteAsync(long id)
        {
            await (_entityManager.DeleteAsync(id));
        }
        [UnitOfWork]
        public virtual async Task MoveAsync(long id, long? parentId)
        {
            await (_entityManager.MoveAsync(  id,  parentId));
        }
        //public async Task<List<OrganizationUnit>> FindChildrenAsync(long? parentId, bool recursive = false)
        //{

        //    await (_entityManager.FindChildrenAsync( parentId, recursive));
        //}



            #endregion


            #region AllMissions

            public IList<OrganizationUnit> GetAllMissions()
        {
            var task = _entityRepository.GetAll().OrderByDescending(t => t.Id);
            return AutoMapper.Mapper.Map<List<OrganizationUnit>>(task);
        }
        [UnitOfWork]
        public OrganizationUnit CreateMission(OrganizationUnit input)
        {
            //var task = AutoMapper.Mapper.Map<Product>(input);

            //var entity = _entityRepository.Insert(task);

            //CurrentUnitOfWork.SaveChanges();
            //return AutoMapper.Mapper.Map<OrganizationUnit>(entity);


            var entity = _entityRepository.Insert(input);
            return entity;
        }
        public OrganizationUnit UpdateMission(OrganizationUnit input)
        {

            //var task = AutoMapper.Mapper.Map<Product>(input); 
            //var entity = _entityRepository.Update(task);
            //CurrentUnitOfWork.SaveChanges();
            //return AutoMapper.Mapper.Map<OrganizationUnit>(entity);

            var entity = _entityRepository.Update(input);
            return entity;
        }

        //[AbpAuthorize(ProductPermissions.Delete)]
        public OrganizationUnit Delete(OrganizationUnit input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            //await _entityRepository.DeleteAsync(input.Id);

            _entityRepository.Delete(input.Id);
            return input;
        }
        #endregion

    }
}
