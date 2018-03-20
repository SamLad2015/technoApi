using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class QualificationTypeViewModelValidator: AbstractValidator<QualificationTypeViewModel>
    {
        public QualificationTypeViewModelValidator()
        {
            RuleFor(qualificationType => qualificationType.QualificationType).NotEmpty().WithMessage("Qualification Type Name cannot be empty");
        }
    }
}