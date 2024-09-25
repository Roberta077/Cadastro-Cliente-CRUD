using Microsoft.EntityFrameworkCore;
using ClienteApp.Models;
using ClienteApp.Data;

namespace ClienteApp.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}       
