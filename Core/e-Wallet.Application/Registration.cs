using e_Wallet.Application.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using e_Wallet.Application.Behaviors;
using FluentValidation;
using System.Globalization;
using e_Wallet.Application.Bases;


namespace e_Wallet.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly =Assembly.GetExecutingAssembly();
            services.AddTransient<ExceptionMiddleware>(); 

            services.AddRulesFromAssemblyContaining(assembly , typeof(BaseRules));    

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture=new CultureInfo("tr");
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehevior<,>));


        }
        private static IServiceCollection AddRulesFromAssemblyContaining(
            this IServiceCollection services,
            Assembly assembly,
            Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                services.AddTransient(item);

            return services;
        }
    }
}
