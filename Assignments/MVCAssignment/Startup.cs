using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MVCAssignment.Repository;
using MVCAssignment.Data;
using MVCAssignment.Models;
using MVCAssignment.Service;
using MVCAssignment.Helpers;

namespace MVCAssignment
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Book Event DB
            services.AddDbContext<BookEventContext>(x => x.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();

            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<BookEventContext>();

            // Password Parameters
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

             /*   options.SignIn.RequireConfirmedEmail = true;

                options.Lockout.MaxFailedAccessAttempts = 5;*/
            });

            // Default Login
            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = _configuration["Application:SignInPath"];
            });

            // Repository

            services.AddScoped<IBookEventRepository, BookEventRepository>();

            services.AddScoped<ISignUpRepository, SignUpRepository>();

            services.AddScoped<ISignInRepository, SignInRepository>();

            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IInvitationRepository, InvitationRepository>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
