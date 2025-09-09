using Microsoft.EntityFrameworkCore;
using TMDB.Abstract;
using TMDB.Data;
using TMDB.Entities;

namespace TMDB.Concrete
{
    public class TMDBRepositry : ITMDBRepo
    {
        Users ITMDBRepo.CreateComments(Users user)
        {
            throw new NotImplementedException();
        }

        void ITMDBRepo.DeleteComments(int id)
        {
            using (var commentsDb = new AppDbContext()) 
            { var deleteComments= commentsDb.Users.Find(id);
                if (deleteComments != null)
                {
                    commentsDb.Users.Remove(deleteComments);
                    commentsDb.SaveChanges();
                }

            }

        }

        List<Users> ITMDBRepo.getAllComments()
        {
            using (var commentsDb = new AppDbContext())
                return commentsDb.Users.ToList();
        }

        Users ITMDBRepo.getCommentById(int id)
        {
            try
            {
                using (
                var commentsDb = new AppDbContext()) {
                   return commentsDb.Users.Find(id);


                } 
            
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework here)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null; // or handle it as needed
            }



        }

        Users ITMDBRepo.UpdateComments(Users user)
        {
            using (var commentsDb = new AppDbContext())
            {
                commentsDb.Users.Update(user);
                return user;
            }
        }
    }
}
