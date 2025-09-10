using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDB.Business.Abstract;
using TMDB.Business.Concrete;
using TMDB.Entities;

namespace TMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tasks : ControllerBase
    {
        private ITasksServices _tasksServices;
        public Tasks(ITasksServices taskServices)
        {
            _tasksServices = taskServices;
            
        }

        [HttpGet]
        public List<Entities.Tasks> Get()
        {
            return _tasksServices.getAllTasks();

        }
        [HttpGet("{id}")]
        public Entities.Tasks Get(int id)
        {
            return _tasksServices.getTasksById(id);
        }
        [HttpPost]
        public Entities.Tasks Post([FromBody] Entities.Tasks task)
        {
            return _tasksServices.CreateTasks(task);
        }
        [HttpPut]
        public Entities.Tasks Put([FromBody] Entities.Tasks task)
        {
            return _tasksServices.UpdateTasks(task);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _tasksServices.DeleteTasks(id);
        }

    }
}
