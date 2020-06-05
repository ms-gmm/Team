using Blog.Application;
using Blog.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IBlogBll _blogBll;

        public UserController(IBlogBll blogBll)
        {
            _blogBll = blogBll;
        }
        [HttpPost]
        public void Add(Blogs blogs)
        {
            _blogBll.Add(blogs);
        }
        [HttpGet]
        public IList<Blogs> GetList()
        {
            return _blogBll.GetList().ToList();
        }
    }
}
