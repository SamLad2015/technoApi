using technoApi.Models;
using technoApi.Models.Article;

namespace technoApi.Repositories
{
    public class ArticleRepository: EntityBaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}