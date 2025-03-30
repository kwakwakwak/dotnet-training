using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Adapters.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}
