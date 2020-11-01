using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Dal.Concrete.EntityFramework.Contexts
{
   public class BookStoreContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB; Database = myDataBase; Trusted_Connection = True");
        }
        public DbSet<Book> Books { get; set; }
    }
}
