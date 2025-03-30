using Core.Ports;
using Microsoft.EntityFrameworkCore;

namespace Adapters.Persistence;

public static class PersistenceExtensions
{
    public static void AddPersistence(
        this IServiceCollection serviceCollection,
        IConfiguration configuration
    )
    {
        serviceCollection.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
        );

        serviceCollection.AddTransient(typeof(ITodo<>), typeof(TodoRepository<>));
    }
}
