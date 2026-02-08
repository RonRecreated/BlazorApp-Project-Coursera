using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class EventRegistration
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name must be under 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int EventId { get; set; }
    }
}
