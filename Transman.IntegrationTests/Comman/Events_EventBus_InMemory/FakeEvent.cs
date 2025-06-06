using Transman.Common.Events;

namespace Transman.IntegrationTests.Comman.Events_EventBus_InMemory;

public record FakeEvent(Guid Id, DateTimeOffset OccurredDateTime, bool Consumed) : IIntegrationEvent
{
    private FakeEvent() : this(Guid.NewGuid(), DateTimeOffset.UtcNow, false)
    {
    }

    internal bool Consumed { get; private set; } = Consumed;

    public void MarkAsConsumed() => Consumed = true;

    public static FakeEvent Create() => new();
}