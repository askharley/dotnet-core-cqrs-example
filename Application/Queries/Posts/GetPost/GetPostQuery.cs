using System;
using Application.Common.Interfaces;
using Domain.Entities;

namespace Application.Queries.Posts.GetPost
{
    public class GetPostQuery : IQuery<Post>
    {
        public Guid PostId { get; set; }
    }
}