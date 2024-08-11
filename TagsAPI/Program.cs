
using Microsoft.EntityFrameworkCore;
using StackOverflowTagsAPI.Database;
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

        builder.Services.AddDbContext<TagsDbContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings"]));
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
        context.Database.Migrate();

        app.Run();

    }
}
