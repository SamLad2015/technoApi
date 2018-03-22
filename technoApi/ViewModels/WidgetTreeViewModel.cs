using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using technoApi.ViewModels.Validations;

namespace technoApi.ViewModels
{
    public class WidgetTreeViewModel: IValidatableObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public int Size { get; set; }
        public string WidgetClass { get; set; }
        
        public List<WidgetTreeViewModel> ChildWidgets { get; set; }
        public ArticleViewModel Article { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new WidgetTreeViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}