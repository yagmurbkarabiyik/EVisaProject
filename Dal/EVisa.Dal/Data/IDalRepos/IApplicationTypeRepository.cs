using EVisa.Core.Services;
using EVisa.Dal.Context;
using EVisa.Dal.Data.Common;
using EVisa.Dal.Data.DalRepos;
using EVisa.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dal.Data.IDalRepos
{
    public interface IApplicationTypeRepository : IRepository<ApplicationType>
    {
       
    }
}
