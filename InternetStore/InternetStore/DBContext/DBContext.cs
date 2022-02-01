using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InternetStore.Entities;
//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data.Entity;

namespace InternetStore
{/// <summary>
/// класс для взаимодействия с контекстом базы данных
/// </summary>
     public class ProductDBContext:DbContext
    {
        public ProductDBContext():base("InternetStore")
        {
            Seed();
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=internetstore;Trusted_Connection=True;");
        //}
        public DbSet<Products> products=>Set<Products>();
        public DbSet<Orders> orders => Set<Orders>();
        public DbSet<Customers> customers => Set<Customers>();
        public DbSet<Warehouses> warehouses=>Set<Warehouses>();
        /// <summary>
        /// первичное заполнение базы номенклатурой товаров
        /// </summary>
        public void Seed()
        {
            Products products1 = new Products()
            {
                Name = "Dress",
                Size = "M",
                Color = "Red",
                Quantity = 3,
                Gender = "Woman",
                Price = 800.00,
                Origin="China"
            };
            Products products2 = new Products()
            {
                Name = "Dress",
                Size = "M",
                Color = "Grey",
                Quantity = 1,
                Gender = "Woman",
                Price = 750.00,
                Origin = "China"
            };
            Products products3 = new Products()
            {
                Name = "Dress",
                Size = "L",
                Color = "Pink",
                Quantity = 5,
                Gender = "Woman",
                Price = 1250.00,
                Origin = "Ukraine"
            };
            Products products4 = new Products()
            {
                Name = "Sweater",
                Size = "S",
                Color = "Green",
                Quantity = 2,
                Gender = "Woman",
                Price = 650.00,
                Origin = "Poland"
            };
            Products products5 = new Products()
            {
                Name = "Shirt",
                Size = "XL",
                Color = "White",
                Quantity = 6,
                Gender = "Woman",
                Price = 530.00,
                Origin = "Hungary"
            };
            Products products6 = new Products()
            {
                Name = "Plaid shirt",
                Size = "XL",
                Color = "White/Black",
                Quantity = 10,
                Gender = "Man",
                Price = 790.00,
                Origin = "Ukraine"
            };
            products.Add(products1);
            products.Add(products2);
            products.Add(products3);
            products.Add(products4);
            products.Add(products5); 
            products.Add(products6);
            
        }
        public void PrintProducts()
        {
            var prod = products.ToList();
            foreach (var item in prod)
            {
                Console.WriteLine($"==============");
                Console.WriteLine(item.ToString());
                Console.WriteLine($"==============");
            }
        }
        /// <summary>
        /// регистрация клиента
        /// </summary>
        public void RegisterUser()
        {
            Customers customer = new Customers();
            Console.WriteLine($"Введите имя:");
            customer.Name = Console.ReadLine();
            Console.WriteLine($"Введите номер телефона:");
            customer.Phone = Console.ReadLine();
            customers.Add(customer);
        }
        /// <summary>
        /// вывод регистрационных данных клиента
        /// </summary>
        public void PrintCustomers()
        {
            var cust = customers.ToList();
            foreach (var item in cust)
            {
                Console.WriteLine(item.ToString());
            }
        }
        /// <summary>
        /// создать заказ
        /// </summary>
        public void CreateOrder()
        {
            Orders order = new Orders();
            Console.WriteLine($"Смотреть товары");
            ProductDBContext myDB = new ProductDBContext();
            myDB.PrintProducts();

        }

    }

}
