using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class WidgetTreeViewModelValidator: AbstractValidator<WidgetTreeViewModel>
    {
        public WidgetTreeViewModelValidator()
        {
            RuleFor(widget => widget.Title).NotEmpty().WithMessage("Widget title cannot be empty");
        }
    }
}