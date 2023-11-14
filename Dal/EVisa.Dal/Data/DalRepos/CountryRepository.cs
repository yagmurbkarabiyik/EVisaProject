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
    public class CountryRepository : Repository<Country, EVisaDbContext>, ICountryRepository
    {
        public CountryRepository(EVisaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
