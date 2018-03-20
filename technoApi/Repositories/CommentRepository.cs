using System.Collections.Generic;
using System.Linq;
using technoApi.Models;
using technoApi.Models.Article;
using technoApi.Models.User;

namespace technoApi.Repositories
{
    public class CommentRepository: EntityBaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}