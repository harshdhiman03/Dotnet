using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class MessageUpdatedEvent : CQRS.Core.Events.BaseEvent
     {
        public MessageUpdatedEvent() : base(nameof(MessageUpdatedEvent))
        {
        }
        public string Message { get; set; }
    }
    
}