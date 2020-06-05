using Blog.Core;
using Blog.Repositorys;
using System;
using System.Collections.Generic;

namespace Blog.Application
{
    public class BlogBll : IBlogBll
    {
        private IRepository<Blogs> _repository;

        public BlogBll(IRepository<Blogs> repository)
        {
            _repository = repository;
        }
        public void Add(Blogs user)
        {
            _repository.Add(user);
        }

        public IList<Blogs> GetList()
        {
            return _repository.GetList();
        }

    }
}
