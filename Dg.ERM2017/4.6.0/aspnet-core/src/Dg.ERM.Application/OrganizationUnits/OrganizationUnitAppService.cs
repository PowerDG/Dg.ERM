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

namespace Dg.ERM.OrganizationUnits
{
   public class OrganizationUnitAppService : ERMAppServiceBase
    {

        private readonly IRepository<Product, int> _entityRepository;

        private readonly IProductManager _entityManager;

        public OrganizationUnitAppService(
        IRepository<Product, int> entityRepository
        , IProductManager entityManager
        )
        {
            _entityRepository = entityRepository;
            _entityManager = entityManager;
        }
    }
}
