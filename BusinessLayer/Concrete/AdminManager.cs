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
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public void Delete(Admin entity)
        {
           _adminDal.Delete(entity);    
        }

        public Admin GetaccordingtoId(int id)
        {
            return _adminDal.GetaccordingtoId(id);
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public void Insert(Admin entity)
        {
            _adminDal.Insert(entity);
        }

        public void Update(Admin entity)
        {
            _adminDal.Update(entity);
        }
    }
}
