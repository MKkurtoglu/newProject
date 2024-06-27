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
    public class SocialMediaManager : ISocialMediaService
    {
        private ISocialMediaDal _socialmedia;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialmedia = socialMediaDal;
        }

        public void Delete(SocialMedia entity)
        {
            _socialmedia.Delete(entity);
        }

        public SocialMedia GetaccordingtoId(int id)
        {
            return _socialmedia.GetaccordingtoId(id);
        }

        public List<SocialMedia> GetAll()
        {
            var values = _socialmedia.GetAll();
            return values;
        }

        public void Insert(SocialMedia entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SocialMedia entity)
        {
            _socialmedia.Update(entity);
        }
    }
}
