using EfDemo.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfDemo.Repository.Concrete.EntityFramework
{
    // Context: Db tablosu ve classların ilişkilendirilmesi
    public class ExampleContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ExampleDB;Trusted_Connection=true");
        }

        public DbSet<Example> Examples { get; set; }
    }
}
