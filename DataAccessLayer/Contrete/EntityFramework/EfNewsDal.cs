using DataAccessLayer.Abstract;
using EntitiyLayer.Abstract;
using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contrete.EntityFramework
{
    public class EfNewsDal : GenericRepository<News, ProjectDbContext>, INewsDal
    {
        public List<News> GetAllStatus(Expression<Func<News, bool>> filter = null)
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                return filter == null ? context.Set<News>().ToList() : context.Set<News>().Where(filter).ToList();
            }
        }

        public void statusChanceToFalse(int id)
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                var values = context.Newses.Find(id);
                values.Status = false;
                context.SaveChanges();
            }
        }

        public void statusChanceToTrue(int id)
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                var values = context.Newses.Find(id);
                values.Status = true;
                context.SaveChanges();
            }
        }
    }
}
