using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autorization.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebHelsi.Entities;

namespace Autorization
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
            services.AddCors();
            //Підключення до бази даних
            services.AddDbContext<EFDbContext>(opt =>
                opt.UseSqlServer(Configuration
                    .GetConnectionString("DefaultConnection")));

            //services.AddIdentity<DbUser, DbRole>()
            //    .AddEntityFrameworkStores<EFDbContext
            //Налаштування Identity для DbUser і DbRole , сховищем буде EFDbContext з використанням дефолтного провайдера
            services.AddIdentity<DbUser, DbRole>(options => options.Stores.MaxLengthForKeys = 128)
                .AddEntityFrameworkStores<EFDbContext>()
                .AddDefaultTokenProviders();
            //Секрутний ключ для шифрування Jwt токена
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("11-sdfasdf-22233222222"));
            //опції Identity
            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 0;
            });
            //Дані по авторизації-авторизація має бути на основі Jwt токена на основі хедерів client
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters()
                {
                    IssuerSigningKey = signingKey,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    // set ClockSkew is zero
                    ClockSkew = TimeSpan.Zero
                };
            });
            //версія Dot.NET токена
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseAuthentication();
            app.UseCors(
                builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //шлях на сервері
            var fileDestDir = env.ContentRootPath;
            string dirName = this.Configuration.GetValue<string>("ImagesPath");
            //Папка де зберігаються фотки
            string dirPathSave = Path.Combine(fileDestDir, dirName);
            if (!Directory.Exists(dirPathSave))
            {
                Directory.CreateDirectory(dirPathSave);
            }
            string imageUrl = "/images";
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(dirPathSave),
                RequestPath = new PathString(imageUrl)
            });


            app.UseMvc();
            //Seeder бази даних
            SeederDB.SeedData(app.ApplicationServices, env, this.Configuration);
        }
    }
}
