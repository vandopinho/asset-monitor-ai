using AssetMonitor.Application.Features.Users.Interfaces;
using AssetMonitor.Application.Features.Users.Services;
using AssetMonitor.Application.Interfaces;
using AssetMonitor.Application.Settings;
using AssetMonitor.Infrastructure.Persistence.Context;
using AssetMonitor.Infrastructure.Repositories;
using AssetMonitor.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AssetMonitor.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // 🔗 Connection String
        var connectionString =
            configuration.GetConnectionString("DefaultConnection");

        // 🗄️ Database
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString));

        // 👤 Users
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();

        // 🔐 JWT Settings (bind correto)
        services.AddOptions<JwtSettings>()
            .Bind(configuration.GetSection("Jwt"));

        // 🔐 JWT Generator
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

        return services;
    }
}