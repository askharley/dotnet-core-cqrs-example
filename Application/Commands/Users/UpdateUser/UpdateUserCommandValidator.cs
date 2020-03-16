using Domain.Entities;
using FluentValidation;

namespace Application.Commands.Users.UpdateUser
{
    public class UpdateUserCommandValidator : AbstractValidator<User>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().NotEmpty().MaximumLength(255);
            RuleFor(x => x.Surname).NotNull().NotEmpty().MaximumLength(255);
            RuleFor(x => x.Email).NotNull().NotEmpty().MaximumLength(255);
            RuleFor(x => x.Handle).NotNull().NotEmpty().MaximumLength(255);
        }
    }
}