using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using Oracle.ManagedDataAccess.Client;
using Hexagon.IService;
using Hexagon.Service;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDbContext<MvcMovieContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

            services.Configure<IISOptions>(options => {
                options.ForwardClientCertificate = false;
            });

            services.AddTransient<IOrgEmployee, OrgEmployee>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
            });

            app.UseAuthentication();

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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areaRoute",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.Run(async (context) =>
            //{
            //    //Demo: Basic ODP.NET Core application for ASP.NET Core
            //    // to connect, query, and return results to a web page

            //    //Create a connection to Oracle			
            //    string conString = "User Id=cad93;Password=cad93;" +

            //    //How to connect to an Oracle DB without SQL*Net configuration file
            //    //  also known as tnsnames.ora.
            //    "Data Source=192.168.48.30:1521/cad93;";

            //    //How to connect to an Oracle DB with a DB alias.
            //    //Uncomment below and comment above.
            //    //"Data Source=<service name alias>;";


            //    using (OracleConnection con = new OracleConnection(conString))
            //    {
            //        using (OracleCommand cmd = con.CreateCommand())
            //        {
            //            try
            //            {
            //                con.Open();
            //                cmd.BindByName = true;

            //                //Use the command to display employee names from 
            //                // the EMPLOYEES table
            //                cmd.CommandText = "select employee_name from organization_employee where organization_id = :id";

            //                // Assign id to the department number 50 
            //                OracleParameter id = new OracleParameter("id", 800);
            //                cmd.Parameters.Add(id);

            //                //Execute the command and use DataReader to display the data
            //                OracleDataReader reader = cmd.ExecuteReader();
            //                while (reader.Read())
            //                {
            //                    await context.Response.WriteAsync("Employee First Name: " + reader.GetString(0) + "\n");
            //                }

            //                reader.Dispose();
            //            }
            //            catch (Exception ex)
            //            {
            //                await context.Response.WriteAsync(ex.Message);
            //            }
            //        }
            //    }

            //});




        }
    }
}
