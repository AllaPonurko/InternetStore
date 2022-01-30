using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InternetStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternetStore.DBContext
{
    internal class CustomersDBContext : DbContext
    {
        public CustomersDBContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=internetstore;Trusted_Connection=True;");
        }
        public DbSet<Customers> customers => Set<Customers>();

        public void RegisterUser()
        {
            Customers customer = new Customers();
            Console.WriteLine($"Введите имя:");
            customer.Name = Console.ReadLine();
            Console.WriteLine($"Введите номер телефона:");
            customer.Phone = Console.ReadLine();
            customers.Add(customer);
        }
        public void PrintCustomers()
        {
            var cust = customers.ToList();
            foreach (var item in cust)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
