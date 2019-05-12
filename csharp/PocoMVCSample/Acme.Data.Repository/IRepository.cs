using System;
using System.Collections.Generic;

namespace Acme.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        int Add(T obj);
        int Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Update(T obj);
    }

}