using Microsoft.Extensions.DependencyInjection;

namespace e_Wallet.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
services.AddSingleton<e_Wallet.Application.Interfaces.AutoMapper.IMapper, e_Wallet.Mapper.Mapper>();        }
    }
}