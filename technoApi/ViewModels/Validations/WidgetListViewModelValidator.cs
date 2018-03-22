using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class WidgetListViewModelValidator: AbstractValidator<WidgetListViewModel>
    {
        public WidgetListViewModelValidator()
        {
            RuleFor(widget => widget.Title).NotEmpty().WithMessage("Widget title cannot be empty");
        }
    }
}