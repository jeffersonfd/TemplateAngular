using Template.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SpaServices.AngularCli;

namespace TemplateAngular
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
            //services.AddControllers();
            //services.AddEndpointsApiExplorer();
            //services.AddSwaggerGen();

            services.AddControllersWithViews();
            services.AddDbContext<TemplateContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("TemplateDB")).EnableSensitiveDataLogging());


            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });


        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
                    
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

        }
    }
}
