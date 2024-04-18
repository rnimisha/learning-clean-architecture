
using Clean.Application.Contracts.Persistence;
using Clean.Domain.Entities;
using MediatR;

namespace Clean.Application.Features;



public class CreateTodoListCommandHandler : IRequestHandler<CreateTodoListCommand, CreateTodoListCommandReponse>
{

    private readonly ITodoRepository _todoRepository;
    public CreateTodoListCommandHandler(ITodoRepository todoRepository){
        _todoRepository = todoRepository;
    }
    public async Task<CreateTodoListCommandReponse> Handle(CreateTodoListCommand request, CancellationToken cancellationToken)
    {
        try{
            var response = new CreateTodoListCommandReponse();
            var todo = new Todo(){
                Title = request.Title,
                User = request.User,
            };
            
            await _todoRepository.AddAsync(todo);
            response.Message = "Task Added successfully";
            return response;
        }catch(Exception e){
            throw new Exception(e.Message);
        }
    }
}