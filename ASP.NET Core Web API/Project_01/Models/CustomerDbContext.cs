using Microsoft.EntityFrameworkCore;

namespace Project_01.Models
{
    public class CustomerDbContext:DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) :base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
