using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class UserEmployees
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
