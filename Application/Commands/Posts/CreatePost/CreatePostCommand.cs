using System;
using Application.Common.Interfaces;

namespace Application.Commands.Posts.CreatePost
{
    public class CreatePostCommand : ICommand<int>
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}