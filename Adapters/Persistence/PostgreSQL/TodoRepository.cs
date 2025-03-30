using Core.Models;
using Core.Ports;
using Microsoft.EntityFrameworkCore;

namespace Adapters.Persistence;

public class TodoRepository<T> : ITodo<Todo>
{
    private readonly ApplicationDbContext db;

    public TodoRepository(ApplicationDbContext dbContext)
    {
        db = dbContext;
    }

    public async Task<List<Todo>> GetAllTodos()
    {
        return await db.Todos.ToListAsync();
    }

    public async Task<List<Todo>> GetCompleteTodos()
    {
        return await db.Todos.Where(t => t.IsComplete).ToListAsync();
    }

    // TODO:  handle case where todo item is not found
    public async Task<Todo?> GetTodo(int id)
    {
        return await db.Todos.FindAsync(id);
    }

    public async Task<Todo> CreateTodo(Todo todoItem)
    {
        //FIXME: add id generation
        db.Todos.Add(todoItem);
        await db.SaveChangesAsync();
        return todoItem;
    }

    // TODO: handle case where todo item is not found
    public async Task<Todo> UpdateTodo(int id, Todo todoItem)
    {
        var todo = await db.Todos.FindAsync(id);
        todo = todoItem;
        await db.SaveChangesAsync();
        return todo;
    }

    // TODO:  handle case where todo item is not found
    public async void DeleteTodo(int id)
    {
        if (await db.Todos.FindAsync(id) is Todo todo)
        {
            db.Todos.Remove(todo);
            await db.SaveChangesAsync();
        }
    }
}
