using TMDB.Abstract;
using TMDB.Business.Abstract;
using TMDB.Entities;

namespace TMDB.Business.Concrete
{
    public class CommentsManager : ICommentsServices

    {
        private ITMDBRepo _commentsRepo;


        public CommentsManager(ITMDBRepo commentsRepo)
        {
            _commentsRepo = commentsRepo;
        }

        Users ICommentsServices.CreateComments(Users user)
        {
            return _commentsRepo.CreateComments(user);
        }

        void ICommentsServices.DeleteComments(int id)
        {
            var comment = _commentsRepo.getCommentById(id);
            if (comment != null)
            {
                _commentsRepo.DeleteComments(id);
            }
        }

        List<Users> ICommentsServices.getAllComments()
        {
            return _commentsRepo.getAllComments();
        }

        Users ICommentsServices.getCommentById(int id)
        {   

            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than zero.", nameof(id));
            }
            return _commentsRepo.getCommentById(id);
        }

        Users ICommentsServices.UpdateComments(Users user)
        {
            return _commentsRepo.UpdateComments(user);

        }
    }
}
