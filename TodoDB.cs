using Microsoft.EntityFrameworkCore;

/// <summary>
/// Class <c>TodoDb</c> is a DbContext class that represents a session with the database and can be used to query and save instances of the Todo class.
/// </summary>
class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}
