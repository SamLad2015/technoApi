using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using technoApi.Interfaces.Services;
using technoApi.Models.Article;
using technoApi.Models.Profile;
using technoApi.Repositories;
using technoApi.ViewModels;

namespace technoApi.Services
{
    public class ArticleService: IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        
        public IEnumerable<Article> GetAllArticles()
        {
            return _articleRepository.GetAll();
        }

        public Article GetArticle(int articleId)
        {
            return _articleRepository.GetSingle(articleId);
        }
    }
}