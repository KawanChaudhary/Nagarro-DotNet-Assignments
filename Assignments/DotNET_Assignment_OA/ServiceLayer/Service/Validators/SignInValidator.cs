using DomainLayer.Models;
using FluentValidation;

namespace ServiceLayer.Service.Validators
{
    public class SignInValidator : AbstractValidator<SignInUserModel>
    {
        public SignInValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email is not in a valid format.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(5).WithMessage("Password must be at least 5 characters long.");
        }
    }
}
