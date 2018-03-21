using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class MenuViewModelValidator: AbstractValidator<MenuViewModel>
    {
        public MenuViewModelValidator()
        {
            RuleFor(menu => menu.Label).NotEmpty().WithMessage("Menu title cannot be empty");
        }
    }
}