using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Core.Commands;

namespace SM_POST.Post.Cmd.Commands
{
    public class NewPostCmd :BaseCommand
    {
        public string Author { get; set; }
        public string Message { get; set; }
    }
}