using FluentValidation;
using CareQual_Tracker.ViewModels;
using CareQual_Tracker.ViewModels.ViewModels; // adjust namespace to actual ViewModel location

namespace CareQual_Tracker.Application.Validation
{
    public class CareQualUserViewModelValidator : AbstractValidator<CareQualUserViewModel>
    {
        public CareQualUserViewModelValidator()
        {
            RuleFor(x => x.EmailAddress).NotEmpty().EmailAddress().WithMessage("Enter a valid email.");
        }
    }
}