using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Core.Commands;
namespace SM_POST.Post.Cmd.Commands
{
    public class EditCommentCmd :BaseCommand
    {
     public Guid CommentId { get; set; }
    public string Comment { get; set; }
    public string UserName { get; set; }

    }
}