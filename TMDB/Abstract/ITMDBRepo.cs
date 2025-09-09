using TMDB.Entities;

namespace TMDB.Abstract
{
    public interface ITMDBRepo
    {
        List<Users> getAllComments();
        Users getCommentById(int id);

        Users CreateComments(Users user);
        Users UpdateComments(Users user);
        void DeleteComments(int id);

    }
}
