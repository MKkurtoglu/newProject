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
    public class RecentProjectManager : IRecentProjectService
    {
        private readonly IRecentProjectDal _recentProjectDal;
        public RecentProjectManager(IRecentProjectDal recentProjectDal)
        {
            _recentProjectDal   = recentProjectDal;
        }

        public void Delete(RecentProject entity)
        {
           _recentProjectDal.Delete(entity);
        }

        public RecentProject GetaccordingtoId(int id)
        {
            return _recentProjectDal.GetaccordingtoId(id);
        }

        public List<RecentProject> GetAll()
        {
            return _recentProjectDal.GetAll();
        }

        public void Insert(RecentProject entity)
        {
            _recentProjectDal.Insert(entity);
        }

        public void Update(RecentProject entity)
        {
            _recentProjectDal.Update(entity);
        }
    }
}
