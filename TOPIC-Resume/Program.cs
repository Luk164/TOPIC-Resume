using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TOPIC_Resume.Areas.Identity;
using TOPIC_Resume.Data;
using TOPIC_Resume.Entities;

namespace TOPIC_Resume
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
            //        throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseLazyLoadingProxies().UseSqlServer(connectionString));

            builder.Services.AddDbContext<ApplicationDbContext>(dbOptionsBuilder =>
                dbOptionsBuilder.SetupDatabaseBuilder(builder.Configuration));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            builder.Services.AddDefaultIdentity<CustomIdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<CustomIdentityUser>>();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddBlazorise(options =>
                {
                    options.Immediate = true;
                })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();

            //TODO: Evaluate
            //Potentially allows to get current user proxy in blazort pages 
            //builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<CustomIdentityUser>>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }

        /// <summary>
        /// Allows Entity Framework to find and migrate DbContext. Only used at design time!
        /// </summary>
        // ReSharper disable once UnusedType.Global Used in design time
        public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext CreateDbContext(string[] args)
            {
                //At design time the appsettings configuration is not loaded automatically
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                return StaticUtilities.SetupDatabase(configuration);
            }
        }
    }
}