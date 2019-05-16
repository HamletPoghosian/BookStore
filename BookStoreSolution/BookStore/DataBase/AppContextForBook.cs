using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookStore.Data
{

    public class AppContextForBook : DbContext
    {
        public AppContextForBook(DbContextOptions<AppContextForBook> options) : base(options)
        { }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                  @"Server=(localdb)\mssqllocaldb;Database=Book_EFCore;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(e =>
            {
                e.HasKey(b => b.Id);
                e.Property(b => b.Id).HasDefaultValueSql("(newid())");
                e.Property(b => b.Name).IsRequired();
                e.Property(b => b.Author).IsRequired().HasDefaultValue(false);
                e.Property(b => b.Popular).IsRequired(); ;
                e.Property(b => b.Price).IsRequired();
                e.Property(b => b.PublishDate).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
