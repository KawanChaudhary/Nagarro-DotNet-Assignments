using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using BusinessLayer.AbstarctFactory.BookEventsFacade;
using BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent;
using BusinessLayer.AbstarctFactory.BookEventsFacade.ConcreteEvent;
using BusinessLayer.ObserverPattern;
using BusinessLayer.PublisherSubscriberPattern;
using DomainLayer.Models;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RepositoryLayer;
using RepositoryLayer.Repository.UnitOfWork;
using ServiceLayer.Service.Helper;
using ServiceLayer.Service.Implementation;
using ServiceLayer.Service.Interface;
using ServiceLayer.Service.Validators;

namespace WebApplication
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
            
            services.AddControllers();

            services.AddTransient<IValidator<SignUpUserModel>, SignUpValidator>();

            services.AddTransient<IValidator<SignInUserModel>, SignInValidator>();

            services.AddTransient<IValidator<BookEventModel>, BookEventValidator>();

            services.AddTransient<IValidator<CommentModel>, CommentValidator>();

            // Database connection
            services.AddDbContext<BookEventContext>(x => {
                x.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            });

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

            services.AddScoped<IBookEventService, BookEventService>();

            services.AddScoped<ISignUpRepository, SignUpRepository>();

            services.AddScoped<ISignInRepository, SignInRepository>();

            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ICommentService, CommentService>();

            services.AddScoped<IInvitationService, InvitationService>();

            services.AddScoped<IBookEventFacade, BookEventFacade>();
            services.AddScoped<IEditEventManager, EditEventManager>();
            services.AddScoped<IAddEventManager, AddEventManager>();
            services.AddScoped<IGetEventManager, GetEventManager>();

            services.AddScoped<ISubject, Subject>();
            services.AddScoped<IObserver, Observer>();

            services.AddScoped<IPublisher, Publisher>();


            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();

            /*services.AddSingleton<ILogger, Logger>();*/

            services.AddSignalR();

            services.AddNotyf(config =>
            {
                config.DurationInSeconds = 10;
                config.IsDismissable = true;
                config.Position = NotyfPosition.TopRight;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseNotyf();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
