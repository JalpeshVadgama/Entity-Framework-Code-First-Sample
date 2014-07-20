using System.Data.Entity;

namespace EntityCodeFirstMigrations
{
    public class CustomerDataContext : DbContext
    {
        public CustomerDataContext()
            : base("CustomerConnectionString")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
