

using Clean.Application.Features;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TodoController: ControllerBase{

    private readonly IMediator _mediator;

    public TodoController(IMediator mediator){
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CreateTodoListCommandReponse>> AddTodo([FromBody] CreateTodoListCommand command){
        var result = await _mediator.Send(command);
        return Ok(result);
    }

}