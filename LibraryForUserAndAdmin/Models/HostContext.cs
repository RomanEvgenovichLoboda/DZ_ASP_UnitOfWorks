using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PZ_ASP_UnitOfWorks.Models
{
    public class HostContext : DbContext
    {
        public DbSet<Not> Nots { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            new ConfigurationBuilder().AddUserSecrets<HostContext>()
                .Build()
                .Providers
                .First()
                .TryGet("connStr", out var connStr);
            //string connStr = "Data Source=SQL5105.site4now.net;Initial Catalog=db_a8dfed_mydatabase1;User Id=db_a8dfed_mydatabase1_admin;Password=2657sgnusmas";
            builder.UseSqlServer(connStr);
        }
    }
}
