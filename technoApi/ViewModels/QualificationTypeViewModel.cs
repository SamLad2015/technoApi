using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using technoApi.ViewModels.Validations;

namespace technoApi.ViewModels
{
    public class QualificationTypeViewModel: IValidatableObject
    {
        public int Id { get; set; }
        public string QualificationType { get; set; }
   
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new QualificationTypeViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}