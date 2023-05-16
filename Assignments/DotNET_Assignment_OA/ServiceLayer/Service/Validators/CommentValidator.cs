using DomainLayer.Models;
using FluentValidation;

namespace ServiceLayer.Service.Validators
{
    public class CommentValidator : AbstractValidator<CommentModel>
    {
        public CommentValidator()
        {
            RuleFor(x => x.Text)
            .NotEmpty().WithMessage("Comment text is required.");

            RuleFor(x => x.EventId)
                .NotEmpty().WithMessage("Event id is required.");
        }
    }
}
