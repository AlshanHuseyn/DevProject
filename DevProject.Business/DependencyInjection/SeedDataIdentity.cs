using DevProject.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace DevProject.Business.DependencyInjection
{
    public class SeedDataIdentity
    {
        public static async Task SeedData(UserManager<AppUser> userManager
            , RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("alik");
            if (adminUser == null)
            {
                AppUser user = new AppUser
                {
                    Name = "Alik",
                    SurName = "Huseyn",
                    UserName = "alik",
                    Email = "alik.huseyn41@gmail.com"
                };
                await userManager.CreateAsync(user, "1");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
