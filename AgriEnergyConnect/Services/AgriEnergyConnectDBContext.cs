using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnect.Services
{
    public class AgriEnergyConnectDBContext : IdentityDbContext<AgriEnergyConnectUser>
    {
        public AgriEnergyConnectDBContext(DbContextOptions<AgriEnergyConnectDBContext> options)
             : base(options)
        {
          
        }


        public DbSet<Product> Products { get; set; }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var employee = new IdentityRole("admin");
            employee.NormalizedName = "admin";

            var user = new IdentityRole("farmer");
            user.NormalizedName = "farmer";

            builder.Entity<IdentityRole>().HasData(employee, user);

        }
    }

}