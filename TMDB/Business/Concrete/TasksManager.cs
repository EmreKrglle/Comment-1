using TMDB.Abstract;
using TMDB.Business.Abstract;
using TMDB.Entities;

namespace TMDB.Business.Concrete
{
    public class TasksManager : ITasksServices

    {
        private ITMDBRepo _tasksRepo;


        public TasksManager(ITMDBRepo tasksRepo)
        {
            _tasksRepo = tasksRepo;
        }

        AppTasks ITasksServices.CreateTasks(AppTasks task)
        {
            return _tasksRepo.CreateTasks(task);
        }

        void ITasksServices.DeleteTasks(int id)
        {
            var task = _tasksRepo.getTasksById(id);
            if (task != null)
            {
                _tasksRepo.DeleteTasks(id);
            }
        }

        List<AppTasks> ITasksServices.getAllTasks()
        {
            return _tasksRepo.getAllTasks();
        }

        AppTasks ITasksServices.getTasksById(int id)
        {   

            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than zero.", nameof(id));
            }
            return _tasksRepo.getTasksById(id);
        }

        AppTasks ITasksServices.UpdateTasks(AppTasks task)
        {
            return _tasksRepo.UpdateTasks(task);

        }
    }
}
