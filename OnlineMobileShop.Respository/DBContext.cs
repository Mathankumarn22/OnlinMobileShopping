using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using OnlineMobileShop.Entity;

namespace OnlineMobileShop.Respository
{
    public class DBContext:DbContext
    {
        public DBContext() :base("OnlineMobileShop")
        {


        }
        public DbSet<Account> account { get; set; }
        public DbSet<Mobile> mobile { get; set; }
        public DbSet<Brand> brand { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
