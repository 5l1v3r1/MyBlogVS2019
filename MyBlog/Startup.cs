using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Data;
using Core.UnitOfWorks;
using Data.UnitOfWork;
using Core.Repositories;
using Core.Services;
using AutoMapper;
using Data.Repositories;
using Service.Services;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace MyBlog
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
            services.AddAuthentication(AzureADB2CDefaults.BearerAuthenticationScheme)
                .AddAzureADB2CBearer(options => Configuration.Bind("AzureAdB2C", options));

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:SqlConStr"].ToString());
            });

            services.AddControllers();

            services.AddAutoMapper(typeof(Startup));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IBlogRepository, BlogRepository>();
            services.AddTransient<IYorumRepository, YorumRepository>();
            services.AddTransient<IEtiketRepository, EtiketRepository>();
            services.AddTransient<IVideoRepository, VideoRepository>();
            services.AddTransient<IImageRepository, ImageRepository>();

            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IYorumService, YorumService>();
            services.AddScoped<IEtiketService, EtiketService>();
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<IImageService, ImageService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
