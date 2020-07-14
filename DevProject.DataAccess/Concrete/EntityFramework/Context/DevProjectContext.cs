using DevProject.DataAccess.Concrete.EntityFramework.Mapping;
using DevProject.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevProject.DataAccess.Concrete.EntityFramework.Context
{
    public class DevProjectContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=DESKTOP-KFT86GG;Initial Catalog=DevProjectDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BildirimMap());
            builder.ApplyConfiguration(new ReportMap());
            base.OnModelCreating(builder);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Bildirim> Bildirimler { get; set; }
    }
}
