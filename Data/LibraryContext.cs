using Libary.CoreApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.CoreApi.Data
{
    public class LibraryContext:DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options):base(options)
        {
        
        }
        #region DbSets
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }  
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        #endregion DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Category
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Noval", IsActive = true },
                new Category { CategoryId = 2, CategoryName = "History", IsActive = true },
                new Category { CategoryId = 3, CategoryName = "Jokes", IsActive = true }

                );
            //Athour
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId=1, AuthorName ="Lema", DoB =DateTime.Parse("01/01/1995"),ContectNo="123456789",Email="lema@gmail.comn",Address="Chittagorm",AuthorInfo="Sample Information", ImageUrl="",IsActive=true},
                new Author { AuthorId=2, AuthorName ="Anware", DoB =DateTime.Parse("01/01/1996"),ContectNo="123455789",Email="Anwar@gmail.comn",Address="Dhaka",AuthorInfo="Sample Information", ImageUrl="",IsActive=true},
                new Author { AuthorId=3, AuthorName ="Ekram", DoB =DateTime.Parse("01/01/1997"),ContectNo="127756789",Email="Ekram@gmail.comn",Address="Chittagorm",AuthorInfo="Sample Information", ImageUrl="",IsActive=true}
                );

            modelBuilder.Entity<Author>().Property(a=>a.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Author>().Property(a => a.DoB).IsRequired();
            modelBuilder.Entity<Category>().Property(a => a.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Publisher>().Property(a => a.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Book>().Property(a => a.IsActive).HasDefaultValue(true);

        }
    }
}
