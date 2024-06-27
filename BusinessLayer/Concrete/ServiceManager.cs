using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _serviceDal;
        public ServiceManager(IServicesDal servicesDal)
        {
            _serviceDal=servicesDal;
        }

        public void Delete(Services entity)
        {
            _serviceDal.Delete(entity); 
        }

        public Services GetaccordingtoId(int id)
        {
          return  _serviceDal.GetaccordingtoId(id);
        }

        public List<Services> GetAll()
        {
           return _serviceDal.GetAll();
        }

        public void Insert(Services entity)
        {
            _serviceDal.Insert(entity);
        }

        public void Update(Services entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
