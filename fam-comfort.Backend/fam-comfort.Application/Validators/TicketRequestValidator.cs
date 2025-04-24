using fam_comfort.Application.Contract.ViewModels;
using FluentValidation;

namespace fam_comfort.Application.Validators;

public class TicketRequestValidator : AbstractValidator<TicketRequest>
{
    public TicketRequestValidator()
    {
        RuleFor(request => request)
            .Must(request => !string.IsNullOrWhiteSpace(request.PhoneNumber) || !string.IsNullOrWhiteSpace(request.Email))
            .WithMessage("Необходимо указать либо номер телефона, либо почту.");
        
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required")
            .NotNull().WithMessage("Title is required")
            .MinimumLength(2).WithMessage("Title must be at least 2 characters")
            .MaximumLength(128).WithMessage("Title must not exceed 128 characters");
        
        RuleFor(request => request.PhoneNumber)
            .Matches(@"^\+?\d{10,15}$").When(request => !string.IsNullOrWhiteSpace(request.PhoneNumber))
            .WithMessage("Номер телефона должен быть в формате +XXXXXXXXXX.");

        RuleFor(request => request.Email)
            .EmailAddress().When(request => !string.IsNullOrWhiteSpace(request.Email))
            .WithMessage("Некорректный формат почты.");
    }
}