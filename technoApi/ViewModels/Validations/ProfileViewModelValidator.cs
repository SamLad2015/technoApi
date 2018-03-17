using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class ProfileViewModelValidator: AbstractValidator<ProfileViewModel>
    {
        public ProfileViewModelValidator()
        {
            RuleFor(profile => profile.FirstName).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}