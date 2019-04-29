

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abp.Organizations;


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

 


namespace Dg.ERM.OrganizationUnits
{
    public class OrganizationUnitAppService    : ERMAppServiceBase
    {

        private readonly IRepository<OrganizationUnit, long> _entityRepository;

        private readonly OrganizationUnitManager _entityManager;

        public OrganizationUnitAppService(
       IRepository<OrganizationUnit, long> entityRepository
       , OrganizationUnitManager entityManager
       )
        {
            _entityRepository = entityRepository;
            _entityManager = entityManager;
        }





    }
}
