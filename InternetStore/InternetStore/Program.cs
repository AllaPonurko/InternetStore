namespace InternetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            using(
            ProductDBContext myDB = new ProductDBContext())
            {
                //myDB.SaveChanges();
                myDB.PrintProducts();
                myDB.RegisterUser();
                myDB.PrintCustomers();
            }
            
        }
    }
}
