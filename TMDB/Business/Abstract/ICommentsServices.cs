namespace TMDB.Business.Abstract
{
    public interface ICommentsServices
    {
        List<Entities.Users> getAllComments();
        Entities.Users getCommentById(int id);
        Entities.Users CreateComments(Entities.Users user);
        Entities.Users UpdateComments(Entities.Users user);
        void DeleteComments(int id);
    }
}
