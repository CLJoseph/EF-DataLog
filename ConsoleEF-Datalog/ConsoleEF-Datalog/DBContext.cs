using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreRepositoryDatalog
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP\SQLEXPRESS;Database=EFCoreRepositoryDatalog;Trusted_Connection=True;");
        }          

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_Address>().Property(p => p.Line001).HasMaxLength(50);
            modelBuilder.Entity<T_Address>().Property(p => p.Line002).HasMaxLength(50);
            modelBuilder.Entity<T_Address>().Property(p => p.Line003).HasMaxLength(50);
            modelBuilder.Entity<T_Address>().Property(p => p.Line004).HasMaxLength(50);
            modelBuilder.Entity<T_Address>().Property(p => p.Line005).HasMaxLength(50);
            modelBuilder.Entity<T_Address>().Property(p => p.Code).HasMaxLength(12);
            modelBuilder.Entity<T_Address>().Property(p => p.ID).IsRequired();

            modelBuilder.Entity<T_Person>().Property(p => p.Title).HasMaxLength(50);
            modelBuilder.Entity<T_Person>().Property(p => p.FirstName).HasMaxLength(50);
            modelBuilder.Entity<T_Person>().Property(p => p.LastName).HasMaxLength(50);

            modelBuilder.Entity<T_DbLog>().Property(p => p.TableName).HasMaxLength(50);
            modelBuilder.Entity<T_DbLog>().Property(p => p.Event).HasMaxLength(25);
            modelBuilder.Entity<T_DbLog>().HasIndex(I => I.LogDateTime);


        }

        public DbSet<T_DbLog>   DBlog     { get; set; }
        public DbSet<T_Person>  People    { get; set; }
        public DbSet<T_Address> Addresses { get; set; }
        public DbSet<T_Lookup>  lookup    { get; set; }
    }
}
