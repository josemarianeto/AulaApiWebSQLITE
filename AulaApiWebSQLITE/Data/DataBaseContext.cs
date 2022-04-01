using AulaApiWebSQLITE.Model;
using Microsoft.EntityFrameworkCore;

namespace AulaApiWebSQLITE.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
