using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace voleyballapp.webui.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            var roles = configuration.GetSection("Data:Roles").GetChildren().Select(r=>r.Value).ToArray();

            foreach (var role in roles)
            {
                if(!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var users = configuration.GetSection("Data:Users");

            foreach (var section in users.GetChildren())
            {
                var username = section.GetValue<string>("username");
                var password = section.GetValue<string>("password");
                var email = section.GetValue<string>("email");
                var role = section.GetValue<string>("role");
                var firstName = section.GetValue<string>("firstName");
                var lastName = section.GetValue<string>("lastName");

                if(await userManager.FindByNameAsync(username) == null)
                {
                    var user = new User()
                    {
                        UserName = username,
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        EmailConfirmed = true
                    };

                    var result = await userManager.CreateAsync(user,password);

                    if(result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user,role);
                    }
                    else
                    {
                        Console.WriteLine("hATA2\n");
                    }
                }
                else
                {
                    Console.WriteLine("hATA3\n");
                }

            
            // var username = configuration["Data:AdminUser:username"];
            // var email = configuration["Data:AdminUser:email"];
            // var password = configuration["Data:AdminUser:password"];
            // var role = configuration["Data:AdminUser:role"];

            // if(await userManager.FindByNameAsync(username) == null)
            // {
            //     await roleManager.CreateAsync(new IdentityRole(role));

            //     var user = new User()
            //     {
            //         UserName = username,
            //         Email = email,
            //         FirstName = "umutadmin",
            //         LastName = "gndzadmin",
            //         EmailConfirmed = true
            //     };

            //     var result = await userManager.CreateAsync(user,password);

            //     if(result.Succeeded)
            //     {
            //         await userManager.AddToRoleAsync(user,role);
            //     }
            }
        }
    }
}