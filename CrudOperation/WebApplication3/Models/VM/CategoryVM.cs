using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.VM
{
    public class CategoryVM
    {
        [Required(ErrorMessage ="Category Name can't empty")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter some description")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please upload the Image")]
        public IFormFile Image { get; set; }
        [Required]
       public int Id { get; set; }

    }
}
