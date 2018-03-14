using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using technoApi.Models;
using technoApi.Models.Context;

namespace technoApi.Controllers
{
    public class WidgetController : Controller
    {
        private readonly DataContext _dataContext;
        
        // GET
        public WidgetController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        // GET
        public IEnumerable<Article> GetAllArticles()
        {
            return _dataContext.Articles.ToList();
        }
        
        [HttpGet("{id}", Name = "GetWidget")]
        public IActionResult GetById(long id)
        {
            var widget = _dataContext.Widgets.FirstOrDefault(p => p.Id == id);
            if (widget == null)
            {
                return NotFound();
            }
            return new ObjectResult(widget);
        }
    }
}