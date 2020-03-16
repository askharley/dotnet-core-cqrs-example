using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common;
using Domain.Entities;
using MediatR;

namespace Application.Commands.Posts.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreatePostCommandHandler(IApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            Post post = new Post
            {
                UserId = request.UserId,
                Title = request.Title,
                Content = request.Content
            };

            _context.Posts.Add(post);
            await _context.SaveChangesAsync(cancellationToken);

            return post.Id;
        }
    }
}