using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using technoApi.Models;
using technoApi.Models.Context;
namespace technoApi.Controllers
{
    public class ArticleController : Controller
    {
        private readonly DataContext _dataContext;

        public ArticleController(DataContext dataContext)
        {
            _dataContext = dataContext;
        } 
        
        // GET
        public IEnumerable<Article> GetAllArticles()
        {
            return _dataContext.Articles.ToList();
        }
        
        [HttpGet("{id}", Name = "GetArticle")]
        public IActionResult GetById(long id)
        {
            var article = _dataContext.Articles.FirstOrDefault(p => p.Id == id);
            if (article == null)
            {
                return NotFound();
            }
            return new ObjectResult(article);
        }
    }
}