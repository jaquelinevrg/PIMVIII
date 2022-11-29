using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ProjetoAds8.Models;
using ProjetoAds8.Repositories;

namespace ProjetoAds8
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
            services.AddDbContext<ProjetoAds8Context>(x => x.UseSqlite("Data source=pessoa.db"));
            services.AddScoped<IProjetoAds8Repository, PessoaRepository>();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjetoAds8", Version = "v1" });
            });
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();    
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjetoAds8 v1"));
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
