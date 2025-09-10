using TMDB.Entities;

namespace TMDB.Abstract
{
    public interface ITMDBRepo
    {
        List<AppTasks> getAllTasks();
        AppTasks getTasksById(int id);

        AppTasks CreateTasks(AppTasks task);
        AppTasks UpdateTasks(AppTasks task);
        void DeleteTasks(int id);

    }
}
