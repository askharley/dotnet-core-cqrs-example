using Domain.Entities;
using FluentValidation;

namespace Application.Commands.Users.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<User>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().MaximumLength(255);
            RuleFor(x => x.Surname).NotNull().NotEmpty().MaximumLength(255);
            RuleFor(x => x.Email).NotNull().NotEmpty().MaximumLength(255);
            RuleFor(x => x.Handle).NotNull().NotEmpty().MaximumLength(255);
        }
    }
}