using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common;
using Domain.Entities;
using MediatR;

namespace Application.Commands.Users.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, User>
    {
        private readonly IApplicationDbContext _context;

        public UpdateUserCommandHandler(IApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User user = await _context.Users.FindAsync(request.Id);

            user.Name = request.Name;
            user.Surname = request.Surname;
            user.Email = request.Email;
            user.Handle = request.Handle;

            _context.Users.Update(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user;
        }
    }
}