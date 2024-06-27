using EntitiyLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Admin : IEntity
    {
        public int AdminID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
