using fam_comfort.Application.ViewModels;
using FluentValidation;

namespace fam_comfort.Application.Validators;

public class FacadeCategoryRequestValidator : AbstractValidator<FacadeCategoryRequest>
{
    public FacadeCategoryRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Please specify a valid name.")
            .NotNull().WithMessage("Please specify a valid name.")
            .MinimumLength(2).WithMessage("Name must be at least 2 characters.")
            .MaximumLength(256).WithMessage("Name must be not more than 256 characters.");
        
        RuleFor(x => x.PathToImage)
            .NotEmpty().WithMessage("Please specify a valid path to image.")
            .NotNull().WithMessage("Please specify a valid path to image.")
            .MaximumLength(2048).WithMessage("Name must be not more than 2048 characters.");
    }
}