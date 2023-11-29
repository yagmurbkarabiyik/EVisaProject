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
    public class DestinationRepository : Repository<Destination, EVisaDbContext>, IDestinationRepository
    {
        public DestinationRepository(EVisaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
