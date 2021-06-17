using Newtonsoft.Json;
using System;

namespace EventBus.Abstractions.Events
{
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            EventId = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        [JsonConstructor]
        public IntegrationEvent(Guid eventId, DateTime createDate)
        {
            EventId = eventId;
            CreationDate = createDate;
        }

        [JsonProperty]
        public Guid EventId { get; set; }

        [JsonProperty]
        public DateTime CreationDate { get; set; }
    }
}
