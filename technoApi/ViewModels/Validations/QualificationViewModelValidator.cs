using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class QualificationViewModelValidator: AbstractValidator<QualificationViewModel>
    {
        public QualificationViewModelValidator()
        {
            RuleFor(Qualification => Qualification.Title).NotEmpty().WithMessage("Qualification Name cannot be empty");
        }
    }
}