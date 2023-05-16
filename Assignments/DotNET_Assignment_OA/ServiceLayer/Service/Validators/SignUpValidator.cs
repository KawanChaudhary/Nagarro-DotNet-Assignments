using DomainLayer.Models;
using FluentValidation;

namespace ServiceLayer.Service.Validators
{
    public class SignUpValidator : AbstractValidator<SignUpUserModel>
    {
        public SignUpValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();

            RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email is not in a valid format.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(5).WithMessage("Password must be at least 5 characters long.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password).WithMessage("Password and confirm password must match.");
        }
    }
}
