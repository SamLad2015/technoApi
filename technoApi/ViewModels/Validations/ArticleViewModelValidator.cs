using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class ArticleViewModelValidator: AbstractValidator<ArticleViewModel>
    {
        public ArticleViewModelValidator()
        {
            RuleFor(article => article.Title).NotEmpty().WithMessage("Article title cannot be empty");
        }
    }
}