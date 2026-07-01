using AssetMonitor.Application.Features.Authentication.Interfaces;
using AssetMonitor.Application.Features.Authentication.Services;
using AssetMonitor.Application.Features.Equipment.Interfaces;
using AssetMonitor.Application.Features.Equipment.Services;
using AssetMonitor.Application.Features.Users.Interfaces;
using AssetMonitor.Application.Features.Users.Services;
using AssetMonitor.Application.Interfaces;
using AssetMonitor.Application.Settings;
using AssetMonitor.Infrastructure.Persistence.Context;
using AssetMonitor.Infrastructure.Persistence.Repositories;
using AssetMonitor.Infrastructure.Repositories;
using AssetMonitor.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        services.AddScoped<IAuthService, AuthService>();

        // 🔐 JWT Settings (bind correto)
        services.AddOptions<JwtSettings>()
            .Bind(configuration.GetSection("Jwt"));

        // 🔐 JWT Generator
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<
            IEquipmentRepository,
            EquipmentRepository>();

        services.AddScoped<
            IEquipmentService,
            EquipmentService>();
        return services;
    }
}