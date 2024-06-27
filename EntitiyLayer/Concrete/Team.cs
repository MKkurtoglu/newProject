using EntitiyLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Team : IEntity
    {
        public int TeamID { get; set; }
        public string PersonName { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string? FacebookURL { get; set; }
        public string? WebsiteURL { get; set; }
        public string? TwitterURL { get; set; }
    }
}
