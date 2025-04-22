using Transman.Common.Events;

namespace Transman.IntegrationTests.Comman.Events_EventBus_InMemory;

public sealed class TestEventConsumer : IIntegrationEventHandler<FakeEvent>
{
    public Task Handle(FakeEvent @event, CancellationToken cancellationToken)
    {
        @event.MarkAsConsumed();
        return Task.CompletedTask;
    }
}