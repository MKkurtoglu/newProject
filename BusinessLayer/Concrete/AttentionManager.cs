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
    public class AttentionManager : IAttentionService
    {
        private readonly IAttentionDal _attentionDal;
        public AttentionManager(IAttentionDal attentionDal)
        {
            _attentionDal = attentionDal;
        }
        public void Delete(Attention entity)
        {
            _attentionDal.Delete(entity);
        }

        public Attention GetaccordingtoId(int id)
        {
            return _attentionDal.GetaccordingtoId(id);
        }

        public List<Attention> GetAll()
        {
            return _attentionDal.GetAll();
        }

        public void Insert(Attention entity)
        {
            _attentionDal.Insert(entity);
        }

        public void Update(Attention entity)
        {
            _attentionDal.Update(entity);
        }
    }
}
