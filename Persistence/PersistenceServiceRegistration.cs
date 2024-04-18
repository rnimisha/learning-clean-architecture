

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Data;
using Npgsql;

using Clean.Application.Contracts.Persistence;
using Clean.Persistence.Repositories;

namespace Clean.Persistence;
public static class PersistenceServiceRegistration{

    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration){
        var connectionString = configuration["ConnectionString:Postgres"];
        services.AddScoped<IDbConnection>(db =>
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            return connection;
        });

        services.AddScoped<ITodoRepository, TodoRepository>();
        return services;

    }
}