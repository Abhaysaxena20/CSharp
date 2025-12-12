using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class MergeModel
    {
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
