
using Clean.Domain.Entities;
using MediatR;

namespace Clean.Application.Features;



public class CreateTodoListCommandHandler : IRequestHandler<CreateTodoListCommand, Todo>
{
    public Task<Todo> Handle(CreateTodoListCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}