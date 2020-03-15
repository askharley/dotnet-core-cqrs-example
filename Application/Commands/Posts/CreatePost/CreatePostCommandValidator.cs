using Domain.Entities;
using FluentValidation;

namespace Application.Commands.Posts.CreatePost
{
    public class CreatePostCommandValidator : AbstractValidator<Post>
    {
        public CreatePostCommandValidator()
        {
            RuleFor(x => x.UserId).NotNull();
            RuleFor(x => x.Title).NotNull().NotEmpty().MaximumLength(255);
            RuleFor(x => x.Content).NotNull().NotEmpty().MaximumLength(2000);
        }
    }
}