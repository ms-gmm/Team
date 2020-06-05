using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Repositorys
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        IList<T> GetList();
    }
}
