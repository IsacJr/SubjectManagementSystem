using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Data.Common;
using Npgsql;
using SubjectManagementSystem.Repository;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace SubjectManagementSystem.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public DbConnection DbConnection => new NpgsqlConnection(Configuration.GetConnectionString("App"));

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            #region Repositories configuration
            //services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IChallengeRepository, ChallengeRepository>();
            services.AddTransient<IClassroomRepository, ClassroomRepository>();
            services.AddTransient<IContractRepository, ContractRepository>();
            services.AddTransient<IFieldRepository, FieldRepository>();
            services.AddTransient<IInstitutionRepository, InstitutionRepository>();
            services.AddTransient<IProblemChallengeRepository, ProblemChallengeRepository>();
            services.AddTransient<IReportRepository, ReportRepository>();
            services.AddTransient<ISolutionRepository, SolutionRepository>();
            services.AddTransient<IStageRepository, StageRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            #endregion

            #region Services configuration
            
            services.AddTransient<IChallengeService, ChallengeService>();
            services.AddTransient<IClassroomService, ClassroomService>();
            services.AddTransient<IContractService, ContractService>();
            services.AddTransient<IFieldService, FieldService>();
            services.AddTransient<IInstitutionService, InstitutionService>();
            services.AddTransient<IProblemChallengeService, ProblemChallengeService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<ISolutionService, SolutionService>();
            services.AddTransient<IStageService, StageService>();
            services.AddTransient<ISubjectService, SubjectService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IUserService, UserService>();
            #endregion
            
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            // Database configuration
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(
                    DbConnection,
                    assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            #region JWT Config

            //aqui vai nossa key secreta, o recomendado é guarda - la no arquivo de configuração
            var secretKey = "ACAC2D1D19DB7100A720E97CCFABF633B7FB77939B278674CA5BAC422F429908";

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            #endregion


            // Register the Swagger Generator service. This service is responsible for genrating Swagger Documents.
            // Note: Add this service at the end after AddMvc() or AddMvcCore().
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "Subject Management API", 
                    Version = "v1",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("CorsPolicy");

            // app.UseHttpsRedirection();

            app.UsePathBase(new PathString("/api"));
            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            


            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Subject Management API V1");

                // To serve SwaggerUI at application's root page, set the RoutePrefix property to an empty string.
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
