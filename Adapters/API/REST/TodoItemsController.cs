using Core.Models;
using Core.Ports;
using Microsoft.AspNetCore.Mvc;

namespace Adapters.API;

[ApiController]
[Route("api/[controller]")]
public class TodoItemsController : ControllerBase
{
    private readonly ITodo<Todo> _iTodo;

    public TodoItemsController(ITodo<Todo> iTodo)
    {
        _iTodo = iTodo;
    }

    // GET: api/TodoItems
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Todo>>> GetTodoItems()
    {
        var result = await _iTodo.GetAllTodos();
        return Ok(result);
    }
}
