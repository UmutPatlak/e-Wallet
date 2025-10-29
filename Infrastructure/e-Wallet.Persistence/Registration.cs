using e_Wallet.Application.Interfaces.Repositories;
using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using e_Wallet.Persistence.Context;
using e_Wallet.Persistence.Repositories;
using e_Wallet.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
namespace e_Wallet.Persistence
{
    public static class Registration
    {
       public static void AddPersistence(this IServiceCollection services,IConfiguration configuration)
        {

            services.AddDbContext<WalletDbContext>(options =>
     options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), sqlServerOptionsAction: sqlOptions =>
     {
         sqlOptions.EnableRetryOnFailure();
     }));

       services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
        services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
                opt.SignIn.RequireConfirmedEmail = false;
            })
                           .AddRoles<Role>()
                           .AddEntityFrameworkStores<WalletDbContext>();
        }
    }
}
