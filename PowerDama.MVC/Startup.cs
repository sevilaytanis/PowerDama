using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace PowerDama.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            #region Auth

            //string SECRET_KEY = Configuration.GetSection("Jwt").GetSection("Key").Value;
            //SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));
            //string jwtBearer = Configuration.GetSection("Jwt").GetSection("Bearer").Value;

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = jwtBearer;
            //    options.DefaultChallengeScheme = jwtBearer;
            //}).AddJwtBearer(jwtBearer, jwt => 
            //{
            //    jwt.TokenValidationParameters = new TokenValidationParameters()
            //    {
            //        IssuerSigningKey = SIGNING_KEY,
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidIssuer = Configuration.GetSection("Jwt").GetSection("Issuer").Value,
            //        ValidAudience = Configuration.GetSection("Jwt").GetSection("Audience").Value,
            //        ValidateLifetime = true
            //    };
            //});

            #endregion
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
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
