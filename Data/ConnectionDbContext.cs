using BlackCoderWeatherAPICALL.Model;
using Microsoft.EntityFrameworkCore;

namespace BlackCoderWeatherAPICALL.Data
{
    public class ConnectionDbContext:DbContext
    {
        public ConnectionDbContext(DbContextOptions options):base(options)
        {


        }
        public DbSet<SaleData> saleData { get; set; }
    }
}
