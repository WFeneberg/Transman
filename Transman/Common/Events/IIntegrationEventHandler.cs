using MediatR;

namespace Transman.Common.Events;

internal interface IIntegrationEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IIntegrationEvent;