using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Transman.Common.Events.Eventbus;
using Transman.IntegrationTests.Base;

namespace Transman.IntegrationTests.Comman.Events_EventBus_InMemory;

public sealed class InMemoryEventBusTests()
{
    
    [Fact]
    internal async Task Given_valid_event_published_Then_event_should_be_consumed()
    {
        
        // Arrange
        UnitTestApplication unitTestApplication = new();
        var eventBus = unitTestApplication.Services.GetRequiredService<IEventBus>();
        var fakeEvent = FakeEvent.Create();
        
        TestEventConsumer consumer = new();
        await consumer.Handle(fakeEvent, CancellationToken.None);

        // Act
        await eventBus!.PublishAsync(fakeEvent, CancellationToken.None);
       
       

        // Assert
        fakeEvent.Consumed.Should().BeTrue();
    }
    
}