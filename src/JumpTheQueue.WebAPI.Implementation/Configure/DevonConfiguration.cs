using System.Reflection;
using System.Security.Claims;
using Devon4Net.Application.WebAPI.Configuration;
using Devon4Net.Domain.UnitOfWork.Common;
using Devon4Net.Domain.UnitOfWork.Enums;
using Devon4Net.Infrastructure.Common.Helpers;
using Devon4Net.Infrastructure.Common.Options.MediatR;
using Devon4Net.Infrastructure.Common.Options.RabbitMq;
using Devon4Net.Infrastructure.FluentValidation;
using Devon4Net.Infrastructure.JWT.Common;
using Devon4Net.Infrastructure.JWT.Common.Const;
using Devon4Net.Infrastructure.MediatR.Samples.Handler;
using Devon4Net.Infrastructure.MediatR.Samples.Model;
using Devon4Net.Infrastructure.MediatR.Samples.Query;
using Devon4Net.Infrastructure.RabbitMQ.Samples.Handllers;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace JumpTheQueue.WebAPI.Implementation.Configure
{
    /// <summary>
    /// DevonConfiguration
    /// </summary>
    public static class DevonConfiguration
    {
        /// <summary>
        /// Sets up the service dependency injection
        /// For example:
        /// services.AddTransient"ITodoService, TodoService"();
        /// services.AddTransient"ITodoRepository, TodoRepository"();
        /// Put your DI declarations here
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void SetupDevonDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            SetupDatabase(ref services, ref configuration);
            SetupJwtPolicies(ref services);
            SetupFluentValidators(ref services);

            var assemblyToScan = Assembly.GetAssembly(typeof(DevonConfiguration));

            services.RegisterAssemblyPublicNonGenericClasses(assemblyToScan)
                .Where(x => x.Name.EndsWith("Service"))
                .AsPublicImplementedInterfaces();

            services.RegisterAssemblyPublicNonGenericClasses(assemblyToScan)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsPublicImplementedInterfaces();


            using var serviceProvider = services.BuildServiceProvider();

            var mediatR = serviceProvider.GetService<IOptions<MediatROptions>>();
            var rabbitMq = serviceProvider.GetService<IOptions<RabbitMqOptions>>();

            //if (rabbitMq?.Value != null && rabbitMq.Value.EnableRabbitMq)
            //{
            //    SetupRabbitHandlers(services);
            //}

            //if (mediatR?.Value != null && mediatR.Value.EnableMediatR)
            //{
            //    SetupMediatRHandlers(services);
            //}
        }

        private static void SetupFluentValidators(ref IServiceCollection services)
        {
            //services.AddFluentValidation<TodosFluentValidator>(true);
            //services.AddFluentValidation<EmployeeFluentValidator>(true);
        }

        /// <summary>
        /// Setup here your database connections.
        /// To use RabbitMq message backup declare the 'RabbitMqBackupContext' database setup
        /// PE: services.SetupDatabase&lt;RabbitMqBackupContext&gt;($"Data Source={FileOperations.GetFileFullPath("RabbitMqBackupSqLite.db")}", DatabaseType.Sqlite);
        /// Please add the connection strings to enable the backup messaging for MediatR abd RabbitMq using MediatRBackupContext and RabbitMqBackupContext
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        private static void SetupDatabase(ref IServiceCollection services, ref IConfiguration configuration)
        {
            services.SetupDatabase<JumpTheQueueContext>(configuration, "JumpTheQueue", DatabaseType.PostgreSQL, migrate:true);
            //services.SetupDatabase<TodoContext>(configuration, "Default", DatabaseType.InMemory);
            //services.SetupDatabase<EmployeeContext>(configuration, "Employee", DatabaseType.InMemory);
        }

        private static void SetupJwtPolicies(ref IServiceCollection services)
        {
            services.AddJwtPolicy(AuthConst.DevonSamplePolicy, ClaimTypes.Role, AuthConst.DevonSampleUserRole);
        }
    }
}
