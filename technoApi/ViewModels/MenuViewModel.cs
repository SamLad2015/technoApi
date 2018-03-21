using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using technoApi.ViewModels.Validations;

namespace technoApi.ViewModels
{
    public class MenuViewModel: IValidatableObject
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Path { get; set; }
        public string FontAwesomeFont { get; set; }
        public int ParentMenuId { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new MenuViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}