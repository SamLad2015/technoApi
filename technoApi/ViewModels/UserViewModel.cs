using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using technoApi.ViewModels.Validations;

namespace technoApi.ViewModels
{
    public class UserViewModel: IValidatableObject
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ProfileName { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new UserViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}