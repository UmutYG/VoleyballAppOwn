using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using voleyball.business.Abstract;
using voleyball.business.Concrete;
using voleyballapp.data.Abstract;
using voleyballapp.data.Concrete.EfCore;
using voleyballapp.webui.Identity;

namespace voleyballapp.webui
{
    public class Startup
    {   
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<VoleyballContext>(options=>options.UseSqlite(_configuration.GetConnectionString("SqliteConnection")));
            services.AddDbContext<IdentityContext>(options=>options.UseSqlite(_configuration.GetConnectionString("SqliteConnection")));

            // services.AddDbContext<VoleyballContext>(options=>options.UseSqlServer(_configuration.GetConnectionString("MsSqlConnection")));
            // services.AddDbContext<IdentityContext>(options=>options.UseSqlServer(_configuration.GetConnectionString("MsSqlConnection")));
            services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();


            services.Configure<IdentityOptions>(options=> {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;

                //Lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                // options.User.AllowedUserNameCharacters = ""
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder // Buraya () da geliyor sanırsam.
                {
                    HttpOnly = true,
                    Name = ".Voleyballapp.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });



            // services.AddScoped<ITeamRepository,EfCoreTeamRepository>();
            // services.AddScoped<IPlayerRepository,EfCorePlayerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPlayerService,PlayerManager>();
            services.AddScoped<ITeamService,TeamManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication(); // ÖNEMLİ! GİRİŞ YAPMALR İÇN
            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "adminRoleEdit",
                    pattern : "admin/role/{id?}",
                    defaults: new {controller="Admin", action="RoleEdit"}
                    
                );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern : "{controller=Home}/{action=Index}"
                    
                );
            });

            //SeedIdentity.Seed(userManager, roleManager, configuration).Wait(); // async diye wait koyduk
        }


       
    }
}
