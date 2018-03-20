using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Models.Article;
using technoApi.Repositories;
using technoApi.ViewModels;

namespace technoApi.Controllers
{
    [Route("api/[controller]")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;
        
        public ArticleController(IArticleService articleService, ICommentService commentService)
        {
            _articleService = articleService;
            _commentService = commentService;
        } 
        
        public IActionResult Get()
        {
            var qualificationVms = Mapper.Map<IEnumerable<Article>, 
                IEnumerable<ArticleViewModel>>(_articleService.GetAllArticles());
            return new OkObjectResult(qualificationVms);
        }
        
        [HttpGet("{id}", Name = "GetArticle")]
        public IActionResult Get(int id)
        {
            var profileVm = Mapper.Map<Article, ArticleViewModel>(_articleService.GetArticle(id));
            var commentVms = Mapper.Map<IEnumerable<Comment>, 
                IEnumerable<CommentViewModel>>(_commentService.GetAllArticleComments(id));
            profileVm.UserComments = commentVms.ToList();
            
            return new OkObjectResult(profileVm);
        }
    }
}