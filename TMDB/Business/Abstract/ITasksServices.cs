namespace TMDB.Business.Abstract
{
    public interface ITasksServices
    {
        List<Entities.AppTasks> getAllTasks();
        Entities.AppTasks getTasksById(int id);
        Entities.AppTasks CreateTasks(Entities.AppTasks task);
        Entities.AppTasks UpdateTasks(Entities.AppTasks task);
        void DeleteTasks(int id);
    }
}
