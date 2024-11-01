using Dotnet.Homeworks.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet.Homeworks.Data.Extensions;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddDataLayer(this IServiceCollection services,  string connectionString)
    {
        return services.AddDbContext<AppDbContext>(builder => builder.UseNpgsql(connectionString));
    }
}