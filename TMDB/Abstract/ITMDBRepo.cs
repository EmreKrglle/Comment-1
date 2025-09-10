using TMDB.Entities;

namespace TMDB.Abstract
{
    public interface ITMDBRepo
    {
        List<Tasks> getAllTasks();
        Tasks getTasksById(int id);

        Tasks CreateTasks(Tasks task);
        Tasks UpdateTasks(Tasks task);
        void DeleteTasks(int id);

    }
}
