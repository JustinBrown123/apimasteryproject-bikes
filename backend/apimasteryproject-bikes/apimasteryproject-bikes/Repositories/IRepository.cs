﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apimasteryproject_bikes.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
