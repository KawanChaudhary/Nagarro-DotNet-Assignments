using DomainLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Service.Validators
{
    public class BookEventValidator: AbstractValidator<BookEventModel>
    {
        public BookEventValidator()
        {
            RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Event name is required.");

            RuleFor(x => x.Location)
                .NotEmpty().WithMessage("Location is required.");

            RuleFor(x => x.Date)
                .NotEmpty().WithMessage("Date is required.")
                .WithMessage("Date cannot be in the past.");

            RuleFor(x => x.StartTime)
                .NotEmpty().WithMessage("Time is required.");
        }
    }
}
