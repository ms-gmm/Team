using Blog.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application
{
    public interface IBlogBll
    {
        void Add(Blogs user);

        IList<Blogs> GetList();
    }
}
