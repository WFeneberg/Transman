using Microsoft.Extensions.DependencyInjection;
using Transman.Common.Events.Eventbus;

namespace Transman.Common.Services;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        collection.AddEventBus();
        // collection.AddSingleton<IRepository, Repository>();
        // collection.AddTransient<BusinessService>();
        // collection.AddTransient<MainViewModel>();
    }
}