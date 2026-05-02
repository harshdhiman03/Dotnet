using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class PostLikedEvent: CQRS.Core.Events.BaseEvent
     {
        public PostLikedEvent() : base(nameof(PostLikedEvent))
        {
        }
     }
    
}