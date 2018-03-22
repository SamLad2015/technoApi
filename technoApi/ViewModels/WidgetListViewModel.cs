using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using technoApi.ViewModels.Validations;

namespace technoApi.ViewModels
{
    public class WidgetListViewModel: IValidatableObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public int Size { get; set; }
        public string WidgetClass { get; set; }
        public int[] ChildWidgetIds { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new WidgetListViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}