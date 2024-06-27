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
    public class NewsManager : INewService
    {
        private readonly INewsDal _newsDal;
        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }
        public void Delete(News entity)
        {
            _newsDal.Delete(entity);
        }

        public News GetaccordingtoId(int id)
        {
           return _newsDal.GetaccordingtoId(id);
        }

        public List<News> GetAll()
        {
            return _newsDal.GetAll();
        }

        public void Insert(News entity)
        {
            _newsDal.Insert(entity);
        }

        public void statusChanceToFalse(int id)
        {
            _newsDal.statusChanceToFalse(id);
        }

        public void statusChanceToTrue(int id)
        {
           _newsDal.statusChanceToTrue(id);
        }

        public void Update(News entity)
        {
           _newsDal.Update(entity);
        }
        public List<News> GetAllStatus(bool status)
        {
            return _newsDal.GetAllStatus(x=>x.Status==true);
        }
    }
}
