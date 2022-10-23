using Microsoft.EntityFrameworkCore;

namespace PZ_ASP_UnitOfWorks.Models
{
    public class HostContext : DbContext
    {
        public DbSet<Not> Nots { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=SQL5105.site4now.net;Initial Catalog=db_a8dfed_mydatabase1;User Id=db_a8dfed_mydatabase1_admin;Password=2657sgnusmas");
        }
    }
}
