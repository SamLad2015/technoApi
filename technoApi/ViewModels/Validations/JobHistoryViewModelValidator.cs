using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class JobHistoryViewModelValidator: AbstractValidator<JobHistoryViewModel>
    {
        public JobHistoryViewModelValidator()
        {
            RuleFor(jobHistory => jobHistory.JobTitle).NotEmpty().WithMessage("Job Title cannot be empty");
        }
    }
}