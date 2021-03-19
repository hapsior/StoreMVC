using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StoreMVC.Domain.Model;
namespace StoreMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Item>()
                .HasOne(p => p.ItemType).WithMany(d => d.Item)
                .HasForeignKey(p => p.ItemTypeId);

            builder.Entity<Order>()
                .HasOne(p => p.Customer).WithMany(p => p.Order)
                .HasForeignKey(p => p.CustomerId);

            builder.Entity<Item>()
                .HasOne(p => p.Stock).WithOne(p => p.Item)
                .HasForeignKey<Item>(p => p.StockId);


        }
    }
}
