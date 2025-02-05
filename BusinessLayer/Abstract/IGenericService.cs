﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService <T> where T : class,new()
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetaccordingtoId(int id);
        List<T> GetAll();
    }
}
