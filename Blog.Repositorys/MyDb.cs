using Blog.Core;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blog.Repositorys
{
    public class MyDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=wdora.com;uid=root;pwd=123123;database=blogDb;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
    }
}
