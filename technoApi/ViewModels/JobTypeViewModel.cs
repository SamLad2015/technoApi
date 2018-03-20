using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using technoApi.ViewModels.Validations;

namespace technoApi.ViewModels
{
    public class JobTypeViewModel: IValidatableObject
    {
        public int Id { get; set; }
        public string JobType { get; set; }
   
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new JobTypeViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}