﻿using EntitiyLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class News : IEntity
    {
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime NewsDate { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; } // durumu true olanalrı o sayfada gstereceğiz
    }
}
