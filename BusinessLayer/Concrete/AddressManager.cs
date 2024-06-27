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
    public class AddressManager : IAddressService
    {
       public IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
           _addressDal = addressDal;
        }
        public void Delete(Address entity)
        {
            throw new NotImplementedException();
        }

        public Address GetaccordingtoId(int id)
        {
           return _addressDal.GetaccordingtoId(id);
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll();
        }

        public void Insert(Address entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Address entity)
        {
            _addressDal.Update(entity);
        }
    }
}
