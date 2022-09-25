using AutoMapper;
using GeekShooping.ProductAPI.Config;
using GeekShooping.ProductAPI.Model.Context;
using GeekShooping.ProductAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //adicionando varial connection
            var connection = builder.Configuration["MySqlConnection:MysqlConnectionString"];
            // Add services to the container.
            //aqui se adiciona os servicos, ao inves de service.AddDatabse... usamos builder.Service
            builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, 
                new MySqlServerVersion(new Version(8, 0, 26))));
            //Configuracao mapper sem a classe start up
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            builder.Services.AddSingleton(mapper);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //injetando o productRepository
            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}