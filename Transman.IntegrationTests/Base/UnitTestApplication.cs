using Avalonia;
using Microsoft.Extensions.DependencyInjection;
using Transman.Common.Services;
using Transman.Persons;


namespace Transman.IntegrationTests.Base;

 public class UnitTestApplication : Application
    { 

        public UnitTestApplication()
        {
            var collection = new ServiceCollection();
            collection.AddCommonServices();
            collection.AddDbContext<PersonDbContext>();
        
            // Creates a ServiceProvider containing services from the provided IServiceCollection
            Services = collection.BuildServiceProvider();

        }


       

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider? Services { get; private set; }
    }
