using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class CmmentUpdateEvent: CQRS.Core.Events.BaseEvent
     {
        public CmmentUpdateEvent() : base(nameof(CmmentUpdateEvent))
        {
        }
        public Guid CommentId { get; set; }
        public string Comment { get; set; }
        public string UserName { get; set; }
        public DateTime EditDate { get; set; }
     }
    
        
    
}