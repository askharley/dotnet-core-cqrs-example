using System;
using Application.Common.Interfaces;

namespace Application.Commands.Posts.DeletePost
{
    public class DeletePostCommand : ICommand<Guid>
    {
        public Guid PostId { get; set; }        
    }
}