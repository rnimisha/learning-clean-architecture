using Clean.Application.Features;
using Clean.Domain.Entities;

namespace Clean.Application.Contracts.Persistence;

public interface ITodoRepository {

    Task AddAsync(Todo todo);
    
}