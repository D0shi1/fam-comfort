using fam_comfort.Application.ViewModels;
using FluentValidation;

namespace fam_comfort.Application.Validators;

public class FacadeRequestValidator : AbstractValidator<FacadeRequest>
{
    public FacadeRequestValidator()
    {
        RuleFor(x => x.FacadeCategoryId)
            .NotEmpty().WithMessage("Please specify a valid id.")
            .NotNull().WithMessage("Please specify a valid id.");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Please specify a valid name.")
            .NotNull().WithMessage("Please specify a valid name.")
            .MinimumLength(2).WithMessage("Name must be at least 2 characters.")
            .MaximumLength(256).WithMessage("Name must be between 2 and 256 characters.");
        
        RuleFor(x => x.ShortName)
            .NotEmpty().WithMessage("Please specify a valid name.")
            .NotNull().WithMessage("Please specify a valid name.")
            .MinimumLength(2).WithMessage("Name must be at least 2 characters.")
            .MaximumLength(128).WithMessage("Name must be between 2 and 128 characters.");
        
        RuleFor(x => x.Length)
            .NotEmpty().WithMessage("Please specify a valid length.")
            .NotNull().WithMessage("Please specify a valid length.")
            .Must(x => x > 0).WithMessage("Length must be positive.");
        
        RuleFor(x => x.Width)
            .NotEmpty().WithMessage("Please specify a valid width.")
            .NotNull().WithMessage("Please specify a valid width.")
            .Must(x => x > 0).WithMessage("Width must be positive.");
        
        RuleFor(x => x.Height)
            .NotEmpty().WithMessage("Please specify a valid height.")
            .NotNull().WithMessage("Please specify a valid height.")
            .Must(x => x > 0).WithMessage("Height must be positive.");
        
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Please specify a valid description.")
            .NotNull().WithMessage("Please specify a valid description.")
            .MinimumLength(2).WithMessage("Description must be at least 2 characters.")
            .MaximumLength(1024).WithMessage("Description must be between 2 and 1024 characters.");

        RuleFor(x => x.Materials)
            .NotEmpty().WithMessage("Please specify a valid materials.")
            .NotNull().WithMessage("Please specify a valid materials.")
            .MaximumLength(256).WithMessage("Materials must be not more than 256 characters.");
        
        RuleFor(x => x.PathToImageSchema)
            .NotEmpty().WithMessage("Please specify a valid path to image schema.")
            .NotNull().WithMessage("Please specify a valid path to image schema.")
            .MaximumLength(2048).WithMessage("PathToImageSchema must be not more than 2048 characters.");
    }
}