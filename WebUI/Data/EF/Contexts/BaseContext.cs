using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore;
using BookStore.Entities.BaseObjects;
using BookStore.Entities.Products;

namespace Data.EF.Contexts
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options)
               : base(options)
        { }
        #region DbSets
        public DbSet<BaseObject> BaseObjects { get; set; }
        public DbSet<TypeObject> TypeObjects { get; set; }
        public DbSet<ProductObject> ProductObjects { get; set; }
        public DbSet<Book> Books { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseObject>().ToTable("BaseObjects");
            modelBuilder.Entity<TypeObject>().ToTable("TypeObjects");
            modelBuilder.Entity<ProductObject>().ToTable("ProductObjects");
            modelBuilder.Entity<Book>().ToTable("Books");

        }
    }
}
