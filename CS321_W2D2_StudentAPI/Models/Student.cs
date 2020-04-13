using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W2D2_StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name cannot be empty")]
        [MaxLength(80, ErrorMessage = "First Name cannot be more than 80 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name cannot be empty")]
        [MaxLength(80, ErrorMessage = "Last Name cannot be more than 80 characters")]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
