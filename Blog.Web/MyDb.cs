using Blog.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web
{
    public class MyDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=wdora.com;uid=root;pwd=123123;database=blogDbOne;");
        }
        public DbSet<User> User;
        public DbSet<Blogs> Blogs;
    }
}
