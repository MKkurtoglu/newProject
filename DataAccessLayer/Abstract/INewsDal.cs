using EntitiyLayer.Abstract;
using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface INewsDal : IGenericDAL<News>
    {
        public void statusChanceToTrue(int id);
        public void statusChanceToFalse(int id);
        public List<News> GetAllStatus(Expression<Func<News, bool>> filter = null);
        
    }
}
