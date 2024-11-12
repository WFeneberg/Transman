using System;
using MediatR;

namespace Transman.Common.Events;

internal interface IIntegrationEvent : INotification
{
    Guid Id { get; }
    DateTimeOffset OccurredDateTime { get; }
}