using Imputations.Application;
using Imputations.Application.Contracts.Services;
using Imputations.DataAccess.Contracts.Repositories;
using Imputations.DataAccess.Services.Respositories;
using Microsoft.Extensions.DependencyInjection;

namespace Imputations.CrossCutting.Configuration
{
    public static class IoC
    {

        public static IServiceCollection Register(this IServiceCollection services)
        {
            AddRegistration(services);
            AddServices(services);
            AddRepository(services);

            return services;
        }

        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IImputationService, ImputationService>();
            services.AddTransient<IProjectService, ProyectService>();
            services.AddTransient<ICalendarService, CalendarService>();
            

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IImputationRepository, ImputationRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<ICalendarRepository, CalendarRepository>();





            return services;
        }




    }
}