using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore;
using BookStore.Entities.BaseObjects;
using BookStore.Entities.Products;
using BookStore.Entities.BookAdditionals;
using BookStore.Entities.Accounting;
using BookStore.Entities;

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
        public DbSet<DictObject> DictObjects { get; set; }
        public DbSet<ProductObject> ProductObjects { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Jenre> Jenres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BaseObject>().ToTable("BaseObjects");
            modelBuilder.Entity<TypeObject>().ToTable("TypeObjects");
            modelBuilder.Entity<DictObject>().ToTable("DictObjects");
            modelBuilder.Entity<ProductObject>().ToTable("ProductObjects");
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Jenre>().ToTable("Jenres");
            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Role>().ToTable("Roles");

        }
    }
}
