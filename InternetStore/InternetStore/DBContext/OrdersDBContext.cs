using System;
using System.Collections.Generic;
using System.Text;
using InternetStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternetStore.DBContext
{
    internal class OrdersDBContext:DbContext
    {
        public OrdersDBContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=internetstore;Trusted_Connection=True;");
        }
        public DbSet<Orders> orders => Set<Orders>();
        public void CreateOrder()
        {
            Orders order = new Orders();
            Console.WriteLine($"Смотреть товары");
            ProductDBContext myDB = new ProductDBContext();
            myDB.PrintProducts();

        }
    }
}
