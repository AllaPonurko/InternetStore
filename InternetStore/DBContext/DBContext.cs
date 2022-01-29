using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace InternetStore
{
     public class MyDBContext:DbContext
    {
        public MyDBContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=internetstore;Trusted_Connection=True;");
        }
        public DbSet<Products> products { get; set; } = null! ;
        
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
            products.Add( products6);
            
        }
        public void Print()
        {
            var prod = products.ToList();
             foreach (var item in prod)
                Console.WriteLine(item.ToString());

        }
    }
}
