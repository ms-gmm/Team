using Blog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Repositorys
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MyDb _myDb;

        public Repository(MyDb myDb)
        {
            _myDb = myDb;
        }
        public void Add(T entity)
        {
            _myDb.Add(entity);
            _myDb.SaveChanges();
        }

        public IList<T> GetList()
        {
            return _myDb.Set<T>().ToList();
        }
    }
}
