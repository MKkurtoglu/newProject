using DataAccessLayer.Abstract;
using EntitiyLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contrete
{
    public class GenericRepository<T,Context> : IGenericDAL<T> where T : class,IEntity, new() where Context : DbContext,new()
    {
        public void Delete(T entity)
        {
            using (Context context = new Context())
            {
                var deger=context.Entry(entity);
                deger.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T GetaccordingtoId(int id)
        {
            using (Context context = new Context())
            {
                var deger = context.Set<T>().Find(id);
                return deger;
            }

        }

        public List<T> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Insert(T entity)
        {
            using (Context context = new Context())
            {
                var deger = context.Entry(entity);
                deger.State= EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (Context context = new Context())
            {
                var deger = context.Entry(entity);
                deger.State = EntityState.Modified; context.SaveChanges();
            }
        }
    }
}
