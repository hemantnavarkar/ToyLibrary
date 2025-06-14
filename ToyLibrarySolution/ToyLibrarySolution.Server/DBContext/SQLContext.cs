using Microsoft.EntityFrameworkCore;
using ToyLibrarySolution.Server.Model;

namespace ToyLibrarySolution.Server.DBContext
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// The DB Set for Customers.
        /// </summary>
        public DbSet<Customers> Customers { get; set; }
    }
}
