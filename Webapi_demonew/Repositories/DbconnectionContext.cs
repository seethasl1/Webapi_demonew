using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Webapi_demonew.Models;


namespace Webapi_demonew.Repositories
{
    public class DbconnectionContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Comment>().ToTable("tblcomment1");


        }
        public DbSet<Comment> Comment { get; set; }

    }
}