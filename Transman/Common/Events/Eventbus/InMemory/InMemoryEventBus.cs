using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Transman.Common.Events.Eventbus.InMemory;

internal sealed class InMemoryEventBus(IMediator mediator) : IEventBus
{
    public async Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : IIntegrationEvent =>
        await mediator.Publish(@event, cancellationToken);
}