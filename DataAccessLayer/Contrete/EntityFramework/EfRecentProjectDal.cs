using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contrete.EntityFramework
{
    public class EfRecentProjectDal : GenericRepository<RecentProject,ProjectDbContext>,IRecentProjectDal
    {
    }
}
