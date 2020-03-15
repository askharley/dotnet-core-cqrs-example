using System;
using Application.Common.Interfaces;

namespace Application.Commands.Posts.CreatePost
{
    public class CreatePostCommand : ICommand<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}