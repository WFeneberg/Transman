using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Transman.Common.Events.Eventbus.InMemory;

namespace Transman.Common.Events.Eventbus;

internal static class EventBusModule
{
    internal static IServiceCollection AddEventBus(this IServiceCollection services) =>
        services.AddInMemoryEventBus(Assembly.GetExecutingAssembly());
}