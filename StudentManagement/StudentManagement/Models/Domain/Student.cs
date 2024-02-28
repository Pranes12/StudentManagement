using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.Domain
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Grade is required")]
        public string Grade { get; set; }
    }

    public class ApplicationUser : IdentityUser
    {
        // Add any additional properties you need
        public string CustomProperty { get; set; }
    }
}
