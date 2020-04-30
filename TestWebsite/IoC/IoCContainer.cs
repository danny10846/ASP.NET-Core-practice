using Microsoft.Extensions.DependencyInjection;
using System;
using TestWebsite.Data;

namespace TestWebsite {

    /// <summary>
    /// The dependency injection container making use of the built in .Net Core service provider
    /// </summary>
    public static class IoCContainer {
        /// <summary>
        /// Service provider for this application
        /// </summary>
        public static IServiceProvider Provider { get; set; }

    }
    /// <summary>
    /// A shorthand access class to get DI services with
    /// </summary>
    public static class IoC {
        /// <summary>
        /// The scoped instance of the <see cref="ApplicationDbContext"/>
        /// </summary>
        public static ApplicationDbContext ApplicationDbContext => IoCContainer.Provider.GetService<ApplicationDbContext>();
    }
}
