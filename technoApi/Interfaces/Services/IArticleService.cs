using System.Collections.Generic;
using technoApi.Models.Article;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface IArticleService
    {
        IEnumerable<Article> GetAllArticles();
        Article GetArticle(int articleId);
    }
}