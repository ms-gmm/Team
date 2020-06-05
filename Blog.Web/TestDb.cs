using Blog.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web
{
    public class TestDb : DbContext
    {
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=wdora.com;uid=root;pwd=123123;database=blogDbgm;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
    }
}
