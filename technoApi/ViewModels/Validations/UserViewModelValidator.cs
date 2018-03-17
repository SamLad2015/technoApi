using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class UserViewModelValidator: AbstractValidator<UserViewModel>
    {
        public UserViewModelValidator()
        {
            RuleFor(user => user.UserName).NotEmpty().WithMessage("Username cannot be empty");
        }
    }
}