using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMDB.Entities
{
    public class Tasks
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public required int title { get; set; }
        public required string body { get; set; }
        public required bool completed { get; set; }
        public required DateTime createdAt { get; set; }    




    }
}
