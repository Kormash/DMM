using DMM.Areas.Identity;
using DMM.Data;
using DMM.Models.Entities;
using DMM.Pages.Shared;
using DMM.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPWrecover.Services;

namespace DMM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(opt =>
            {
                opt.ConsentCookie.Name = "ConsentCookie";
                opt.CheckConsentNeeded = context => true;
            });
            services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);

            services.AddDbContextFactory<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ApplicationDbContext>(p => p.GetRequiredService<IDbContextFactory<ApplicationDbContext>>().CreateDbContext());

            services.AddSyncfusionBlazor();

            services.AddScoped<CampaignService>();
            services.AddScoped<MonsterService>();
            services.AddScoped<IconService>();
            services.AddScoped<MonsterTemplateService>();
            services.AddScoped<AreaService>();
            services.AddScoped<LocationService>();
            services.AddScoped<NoteService>();
            services.AddScoped<MapService>();
            services.AddScoped<TraitService>();
            services.AddScoped<MonsterActionService>();

            services.AddScoped<ActionTemplate>();
            services.AddScoped<Area>();
            services.AddScoped<AttatchedFile>();
            services.AddScoped<Campaign>();
            services.AddScoped<Item>();
            services.AddScoped<ItemFeatureTrait>();
            services.AddScoped<Location>();
            services.AddScoped<Loot>();
            services.AddScoped<Map>();
            services.AddScoped<Monster>();
            services.AddScoped<MonsterAction>();
            services.AddScoped<MonsterTemplate>();
            services.AddScoped<Note>();
            services.AddScoped<Player>();
            services.AddScoped<Trait>();
            services.AddScoped<TraitTemplate>(); 

            services.AddTransient<UserManager<IdentityUser>>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDUxNjM5QDMxMzkyZTMxMmUzMFY2eWY2WnpkRVZWT0kwMTB2bm9mT0pOK0laRWt4eFYwbzBTMzVPakxvV3M9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
