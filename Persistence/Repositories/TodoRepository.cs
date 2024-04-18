using System.Data;

using Dapper;

using Clean.Application.Contracts.Persistence;
using Clean.Application.Features;
using Clean.Domain.Entities;


namespace Clean.Persistence.Repositories;

public class TodoRepository : ITodoRepository
{

    private readonly IDbConnection _dbConnection;

    public TodoRepository(IDbConnection dbConnection){
        _dbConnection = dbConnection;
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
    }

    public async Task AddAsync(Todo todo)
    {
        string sql = "INSERT INTO todos (id, title, user_id) VALUES(@Id, @Title, @User)";
        await _dbConnection.ExecuteAsync(sql, todo);
        return;
    }
}