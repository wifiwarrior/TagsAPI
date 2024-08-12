
using Microsoft.EntityFrameworkCore;
using StackOverflowTagsAPI.Database;
using System.Runtime.CompilerServices;
using TagsAPI.Interfaces;
using TagsAPI.Services;

namespace TagsAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Configuration.AddUserSecrets<Program>();


        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        //wstrzykiwanie kontekstu bazy danych =>
        var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
        var dbName = Environment.GetEnvironmentVariable("DB_NAME");
        var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD");
        var connectionString = $"Data Source={dbHost};Initial Catalog={dbName};User ID=sa;Password={dbPassword};TrustServerCertificate=True";

        //builder.Services.AddDbContext<TagsDbContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings"]));
        builder.Services.AddDbContext<TagsDbContext>(options => options.UseSqlServer(connectionString));
        builder.Services.AddScoped<ITagsDbRepository, TagsDbRepository>();
        builder.Services.AddSingleton<StackOverflowClient>();

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


        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetService<TagsDbContext>();

        //redundantne, dockerfile powinien siê zaj¹æ migracjami(?)
        //aczkolwiek wed³ug dokumentacji i po sprawdzeniu powinien siê sprawdziæ na ten use case
       
        context.Database.Migrate();


        app.Run();

    }
}
