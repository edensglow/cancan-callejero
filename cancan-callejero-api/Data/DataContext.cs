using cancan_callejero_api.Models;
using Microsoft.EntityFrameworkCore;

namespace cancan_callejero_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}