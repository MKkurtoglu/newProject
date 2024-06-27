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
    public class ImageManager : IımageService
    {
        private readonly IImageDal _ımageDal;
        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }
        public void Delete(Image entity)
        {
            _ımageDal.Delete(entity);
        }

        public Image GetaccordingtoId(int id)
        {
          return  _ımageDal.GetaccordingtoId(id);
        }

        public List<Image> GetAll()
        {
          return  _ımageDal.GetAll();
        }

        public void Insert(Image entity)
        {
            _ımageDal.Insert(entity);
        }

        public void Update(Image entity)
        {
            _ımageDal.Update(entity);
        }
    }
}
