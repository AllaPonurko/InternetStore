using System;
using static System.Console;
namespace InternetStore
{
    class Program
    {
        static void Main(string[] args)
        {using(
            MyDBContext myDB = new MyDBContext())
            {
                myDB.Seed();
                myDB.SaveChanges();
                myDB.Print();
            }
        }
    }
}
