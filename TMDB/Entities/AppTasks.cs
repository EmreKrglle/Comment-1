using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMDB.Entities
{
    public class AppTasks
    {

        public enum TaskPriority
        {
            Low,
            Medium,
            High
        };

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public required string title { get; set; }
        public required string body { get; set; }
        public required bool completed { get; set; }
        public required DateTime createdAt { get; set; } = DateTime.Now;
        public ICollection<User>? Users { get; set; } = new List<User>();
        public TaskPriority? Priority { get; set; }=TaskPriority.Medium;





    }
}
