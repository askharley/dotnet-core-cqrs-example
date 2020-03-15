using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common;
using Application.Common.Interfaces;
using Domain.Entities;

namespace Application.Queries.Users.GetUser
{
    public class GetUserQueryHandler : IQueryHandler<GetUserQuery, User>
    {
        private IApplicationDbContext _context;

        public GetUserQueryHandler(IApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await _context.Users.FindAsync(request.UserId);
        }
    }
}