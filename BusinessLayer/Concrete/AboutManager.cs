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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public About GetaccordingtoId(int id)
        {
            return _aboutDal.GetaccordingtoId(id);
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public void Insert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
