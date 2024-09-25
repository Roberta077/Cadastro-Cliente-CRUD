using Microsoft.EntityFrameworkCore;

namespace ClienteApp.Data
{
    public class ApplicationsDbContext : DbContext
         : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
}