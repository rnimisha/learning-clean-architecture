
using Clean.Domain.Entities;
using MediatR;

namespace Clean.Application.Features;



public class CreateTodoListCommandHandler : IRequestHandler<CreateTodoListCommand, Todo>
{
    public Task<Todo> Handle(CreateTodoListCommand request, CancellationToken cancellationToken)
    {
        try{
            throw new NotImplementedException();
        }catch(Exception e){
            throw new Exception(e.Message);
        }
    }
}