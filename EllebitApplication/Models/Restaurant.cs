using System.ComponentModel.DataAnnotations;

namespace EllebitApplication.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? category { get; set; }
        public int NumRooms { get; set; }

        public ICollection<MenuItem>? MenuItems { get; set; }
    }
}
