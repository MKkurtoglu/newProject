using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INewService : IGenericService<News>
    {
        public void statusChanceToFalse(int id);
        public void statusChanceToTrue(int id);
    }
}
