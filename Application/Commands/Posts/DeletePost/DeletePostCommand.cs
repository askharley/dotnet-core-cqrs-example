using System;
using Application.Common.Interfaces;

namespace Application.Commands.Posts.DeletePost
{
    public class DeletePostCommand : ICommand<int>
    {
        public int PostId { get; set; }        
    }
}