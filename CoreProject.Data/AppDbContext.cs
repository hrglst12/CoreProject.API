using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CoreProject.Data.Seeds;
using CoreProject.Core.Models;
using CoreProject.Data.Configurations;

namespace CoreProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)// startup.cs dosyasinda options'u dolduruyor olucam
        {
        }
        public DbSet<Category> Categories { get; set; }//tablolara karsilik gelen dbsetler

        public DbSet<Product> Products { get; set; }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//veritabaninda tablolar olusmadan once calisacak olan metod
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());//burda once tabloları olusturuyorum
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());//burda once tabloları olusturuyorum, sonra alttaki satirlarda datalar tablolara eklenicek

            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));//category id'leri verdim

            modelBuilder.Entity<Person>().HasKey(x => x.Id);
            modelBuilder.Entity<Person>().Property(x => x.Id).UseIdentityColumn();
            modelBuilder.Entity<Person>().Property(x => x.Name).HasMaxLength(100);

            modelBuilder.Entity<Person>().Property(x => x.SurName).HasMaxLength(100);
        }
    }
}