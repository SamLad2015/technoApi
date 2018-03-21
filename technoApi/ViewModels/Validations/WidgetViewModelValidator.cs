using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class WidgetViewModelValidator: AbstractValidator<WidgetViewModel>
    {
        public WidgetViewModelValidator()
        {
            RuleFor(widget => widget.Title).NotEmpty().WithMessage("Widget title cannot be empty");
        }
    }
}