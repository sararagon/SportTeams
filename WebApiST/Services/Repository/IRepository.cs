using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ModelsST;

namespace ServicesST.Repository
{
  
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}