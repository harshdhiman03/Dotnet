using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class CommentRemoveEvent: CQRS.Core.Events.BaseEvent
     {
        public CommentRemoveEvent() : base(nameof(CommentRemoveEvent))
        {
        }
        public Guid CommentId { get; set; }
        
     }
   
}