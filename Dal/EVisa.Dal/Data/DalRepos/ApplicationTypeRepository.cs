using EVisa.Dal.Context;
using EVisa.Dal.Data.Common;
using EVisa.Dal.Data.IDalRepos;
using EVisa.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dal.Data.DalRepos
{
    public class ApplicationTypeRepository : Repository<ApplicationType, EVisaDbContext>, IApplicationTypeRepository
    {
        public ApplicationTypeRepository(EVisaDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<ApplicationType> Get()
        {
            throw new NotImplementedException();
        }
    }
}
