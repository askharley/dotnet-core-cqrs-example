using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common;
using Domain.Entities;
using MediatR;

namespace Application.Commands.Posts.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeletePostCommandHandler(IApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task<int> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            Post post = await _context.Posts.FindAsync(request.PostId);

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync(cancellationToken);

            return 2;
        }
    }
}