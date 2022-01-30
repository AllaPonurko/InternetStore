using InternetStore.DBContext;
using System;
using static System.Console;
namespace InternetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            using(
            ProductDBContext myDB = new ProductDBContext())
            {
                myDB.SaveChanges();
                myDB.PrintProducts();
                
            }
            using (CustomersDBContext CusDB = new CustomersDBContext())
            {
                CusDB.RegisterUser();
                CusDB.SaveChanges();
                CusDB.PrintCustomers();
            }
        }
    }
}
