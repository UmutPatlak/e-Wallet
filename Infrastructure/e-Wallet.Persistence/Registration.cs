using e_Wallet.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

       


        }
    }
}
