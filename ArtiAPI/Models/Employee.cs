using System.ComponentModel.DataAnnotations;

namespace ArtiAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
    }
}
