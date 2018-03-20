using FluentValidation;
namespace technoApi.ViewModels.Validations
{
    public class JobTypeViewModelValidator: AbstractValidator<JobTypeViewModel>
    {
        public JobTypeViewModelValidator()
        {
            RuleFor(jobType => jobType.JobType).NotEmpty().WithMessage("Job Type Name cannot be empty");
        }
    }
}