using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.VM
{
    public class EmployeeVM
    {
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(pattern: "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Phone number is required")]
        [RegularExpression(@"^(?:\+91[\-\s]?|0)?[6-9]\d{9}$",ErrorMessage="Invalid Indian Mobile Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please Select Your Gender")]
        public string Gender { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(250)]
        public string Address { get; set; }
        [Required(ErrorMessage ="Pin Code is Required")]
        [RegularExpression(@"^[1-9][0-9]{5}$",ErrorMessage ="Enter a valid 6-digit Pin Code")]
        public string Pincode { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
         ErrorMessage = "Password must be at least 8 characters long and include 1 uppercase, 1 lowercase, 1 number, and 1 special character.")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Please confirm your password.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        public List<string> Skills { get; set; } = new List<string>();
    }
}
