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
    public class CommentService: ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IProfileRepository _profileRepository;

        public CommentService(ICommentRepository commentRepository, IUserRepository userRepository, IProfileRepository profileRepository)
        {
            _commentRepository = commentRepository;
            _userRepository = userRepository;
            _profileRepository = profileRepository;
        }
        
        public IEnumerable<Comment> GetAllArticleComments(int articleId)
        {
            var comments = _commentRepository.FindBy(c => c.ArticleId == articleId).ToList();
            foreach (var comment in comments)
            {
                comment.User = _userRepository.GetSingle(comment.UserId);
                comment.User.Profile = _profileRepository.GetSingle(comment.User.ProfileId);
            }

            return comments;
        }

        public Comment GetArticleComment(int commentId)
        {
            return _commentRepository.GetSingle(commentId);
        }
    }
}