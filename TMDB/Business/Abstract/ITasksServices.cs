namespace TMDB.Business.Abstract
{
    public interface ITasksServices
    {
        List<Entities.Tasks> getAllTasks();
        Entities.Tasks getTasksById(int id);
        Entities.Tasks CreateTasks(Entities.Tasks task);
        Entities.Tasks UpdateTasks(Entities.Tasks task);
        void DeleteTasks(int id);
    }
}
