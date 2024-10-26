using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NIC { get; set; }
        public string  FirstName { get; set; }=string.Empty;
        public string LastName { get; set; }= string.Empty;
        public string ?Email { get; set; }
        [Required]
        public string ?Password { get; set; }

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        public Address? Address { get; set; } 
    }
}
