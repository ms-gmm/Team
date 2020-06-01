using Blog.Core;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blog.Repository
{
    public class BlogDb:DbContext
    {
        //public BlogDb(DbContextOptions options):base(options){

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=wdora.com;uid=root;pwd=123123;database=blogDb");
        }
        public DbSet<User> Users;

        public DbSet<Blogs> Blogs;

    }

}
