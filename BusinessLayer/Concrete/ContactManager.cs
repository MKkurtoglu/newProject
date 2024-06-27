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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact GetaccordingtoId(int id)
        {
           return _contactDal.GetaccordingtoId(id);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }
        public void Insert(Contact entity)
        {
           _contactDal.Insert(entity);
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
