using System;
namespace EntityCodeFirstMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new CustomerDataContext())
            {
                ////Adding a customer
                //dbContext.Customers.Add(
                //    new Customer { 
                //        FirstName="Vishal",
                //        LastName="Vadgama"
                //    }
                //);
                //dbContext.SaveChanges();

                //Displaying Customer
                foreach (Customer customer in dbContext.Customers)
                {
                    Console.WriteLine(customer.FirstName);
                    Console.WriteLine(customer.LastName);
                    Console.WriteLine("---------------");
                }
            }
        }
    }
}
