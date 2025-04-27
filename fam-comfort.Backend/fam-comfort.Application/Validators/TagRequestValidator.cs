using fam_comfort.Application.Contract.ViewModels;
using fam_comfort.Core.Models;
using FluentValidation;

namespace fam_comfort.Application.Validators;

public class TagRequestValidator : AbstractValidator<TagRequest>
{
    public TagRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .NotNull().WithMessage("Name is required")
            .MinimumLength(2).WithMessage("Name must be at least 2 characters")
            .MaximumLength(32).WithMessage("Name must not exceed 32 characters");
    }
}