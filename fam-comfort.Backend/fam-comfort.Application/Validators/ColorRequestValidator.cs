using fam_comfort.Application.Contract.ViewModels;
using FluentValidation;

namespace fam_comfort.Application.Validators;

public class ColorRequestValidator : AbstractValidator<ColorRequest>
{
    public ColorRequestValidator()
    {
        RuleFor(c => c.ProductId)
            .NotEmpty().WithMessage("Please specify a valid id.")
            .NotNull().WithMessage("Please specify a valid id.");
        
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Please specify a valid name.")
            .NotNull().WithMessage("Please specify a valid name.")
            .MinimumLength(3).WithMessage("Name must be at least 3 characters.")
            .MaximumLength(256).WithMessage("Name must be not more than 256 characters.");
        
        RuleFor(c => c.PathToImage)
            .NotEmpty().WithMessage("Please specify a valid path to image.")
            .NotNull().WithMessage("Please specify a valid path to image.")
            .MaximumLength(2048).WithMessage("Path must be not more than 2048 characters.");
    }
}