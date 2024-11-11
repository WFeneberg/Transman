using System.Threading;
using System.Threading.Tasks;

namespace Transman.Common.Events.Eventbus.InMemory;

internal interface IEventBus
{
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default)
        where TEvent : IIntegrationEvent;
}