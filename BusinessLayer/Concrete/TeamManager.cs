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
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _ITeamDal;
        public TeamManager( ITeamDal teamDal )
        {
            _ITeamDal = teamDal;
        }
        public void Delete(Team entity)
        {
            _ITeamDal.Delete(entity);
        }

        public Team GetaccordingtoId(int id)
        {
           return  _ITeamDal.GetaccordingtoId(id);
        }

        public List<Team> GetAll()
        {
           return _ITeamDal.GetAll();
        }

        public void Insert(Team entity)
        {
            _ITeamDal.Insert(entity);
        }

        public void Update(Team entity)
        {
           _ITeamDal.Update(entity);
        }
    }
}
