using System;
using MediatR;

namespace Transman.Common.Events;

public interface IIntegrationEvent : INotification
{
    Guid Id { get; }
    DateTimeOffset OccurredDateTime { get; }
}