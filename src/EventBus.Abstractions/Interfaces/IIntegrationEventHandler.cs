using EventBus.Abstractions.Events;
using System.Threading.Tasks;

namespace EventBus.Abstractions
{
    public interface IIntegrationEventHandler<in TGermesEvent> : IIntegrationEventHandler
        where TGermesEvent : IntegrationEvent
    {
        Task Handle(TGermesEvent @event);
    }

    public interface IIntegrationEventHandler
    {
    }
}
