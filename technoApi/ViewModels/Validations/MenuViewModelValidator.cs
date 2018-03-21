using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class MenuViewModelValidator: AbstractValidator<MenuViewModel>
    {
        public MenuViewModelValidator()
        {
            RuleFor(menu => menu.Title).NotEmpty().WithMessage("Menu title cannot be empty");
        }
    }
}