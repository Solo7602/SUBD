using DATABASE.TABLES;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.IO;

namespace DATABASE
{
    class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Laba5;Username=user;Password=1111");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Hotel> Hotels { set; get; }
    }
}
