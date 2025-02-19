using System.ComponentModel.DataAnnotations;

namespace WebApiClient.Pages
{
    public class StudTable
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name must be at most 50 characters long")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }
    }
}
