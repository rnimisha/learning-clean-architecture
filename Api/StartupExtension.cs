using Clean.Persistence;
using Clean.Application;
using Boss.Gateway.Persistence;

namespace Clean.Api;

public static class StartupExtension{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        DbUpMigrator.MigrateDatabase(builder.Configuration);

        builder.Services.AddApplicationServices();
        builder.Services.AddPersistenceServices(builder.Configuration);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app){
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        return app;
    }
}