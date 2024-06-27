using EntitiyLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class,IEntity,new()
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetaccordingtoId(int id);
        List<T> GetAll();
    }
}
