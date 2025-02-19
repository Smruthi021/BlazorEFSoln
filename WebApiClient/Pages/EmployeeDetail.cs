using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiClient.Pages
{
    public class EmployeeDetail
    {
        [Key] // Marks EmployeeId as the primary key
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Gender is required")]
        public string? Gender { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string? Department { get; set; }

        [Required(ErrorMessage = "Job Title is required")]
        public string? JobTitle { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = null!;

        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string? PhoneNumber { get; set; }

        [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters")]
        public string? Address { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? DateOfJoining { get; set; }

        [Required(ErrorMessage = "Employment Type is required")]
        public string? EmploymentType { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string? Status { get; set; }
    }
}
