using System.Collections.Generic;
using technoApi.Models.Article;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetAllArticleComments(int articleId);
        Comment GetArticleComment(int commentId);
    }
}