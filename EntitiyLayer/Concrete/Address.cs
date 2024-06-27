using EntitiyLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Address : IEntity
    {
        public int AddressID { get; set; }
        public string Despriction1 { get; set; }
        public string Despriction2 { get; set; }
        public string Despriction3 { get; set; }
        public string Despriction4   { get; set; }
        public string MapInfo { get; set; }
    }
}
