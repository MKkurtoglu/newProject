using EntitiyLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class About : IEntity
    {
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Descpriction1 { get; set; }
        public string Descpriction2 { get; set; }
    }
}
