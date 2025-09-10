using System.ComponentModel.DataAnnotations;

namespace TMDB.Entities
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        public string name { get; set; }
        public ICollection<AppTasks> Tasks { get; set; } = new List<AppTasks>();

    }
}
    