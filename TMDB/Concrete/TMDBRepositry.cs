using Microsoft.EntityFrameworkCore;
using TMDB.Abstract;
using TMDB.Data;
using TMDB.Entities;

namespace TMDB.Concrete
{
    public class TMDBRepositry : ITMDBRepo
    {
        AppTasks ITMDBRepo.CreateTasks(AppTasks task)
        {
            using (var tasksDb = new AppDbContext())
            {
                tasksDb.Task.Add(task);
                tasksDb.SaveChanges();
                return task;

            }
        }

        void ITMDBRepo.DeleteTasks(int id)
        {
            using (var tasksDb = new AppDbContext()) 
            { var deleteTasks= tasksDb.Task.Find(id);
                if (deleteTasks != null)
                {
                    tasksDb.Task.Remove(deleteTasks);
                    tasksDb.SaveChanges();
                }

            }

        }

        List<AppTasks> ITMDBRepo.getAllTasks()
        {
            using (var tasksDb = new AppDbContext())
                return tasksDb.Task.ToList();
        }

        AppTasks ITMDBRepo.getTasksById(int id)
        {
            try
            {
                using (
                var tasksDb = new AppDbContext()) {
                   return tasksDb.Task.Find(id);


                } 
            
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework here)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null; // or handle it as needed
            }



        }

        AppTasks ITMDBRepo.UpdateTasks(AppTasks task)
        {
            using (var tasksDb = new AppDbContext())
            {
                tasksDb.Task.Update(task);
                return task;
            }
        }
    }
}
