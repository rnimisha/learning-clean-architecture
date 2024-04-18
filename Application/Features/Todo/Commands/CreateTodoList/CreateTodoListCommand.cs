using Clean.Domain.Entities;
using MediatR;

namespace Clean.Application.Features;
public sealed record CreateTodoListCommand(Guid User, string Title) : IRequest<CreateTodoListCommandReponse>;