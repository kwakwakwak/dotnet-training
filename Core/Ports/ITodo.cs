namespace Core.Ports;

public interface ITodo<Todo>
{
    Task<List<Todo>> GetAllTodos();
    Task<List<Todo>> GetCompleteTodos();
    Task<Todo?> GetTodo(int id);
    Task<Todo> CreateTodo(Todo todo);
    Task<Todo> UpdateTodo(int id, Todo todo);
    void DeleteTodo(int id);
}
