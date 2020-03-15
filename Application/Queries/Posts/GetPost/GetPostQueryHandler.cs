using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common;
using Application.Common.Interfaces;
using Domain.Entities;

namespace Application.Queries.Posts.GetPost
{
    public class GetPostQueryHandler : IQueryHandler<GetPostQuery, Post>
    {
        private IApplicationDbContext _context;

        public GetPostQueryHandler(IApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task<Post> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            return await _context.Posts.FindAsync(request.PostId);
        }
    }
}