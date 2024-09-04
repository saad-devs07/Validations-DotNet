using System.ComponentModel.DataAnnotations;

namespace Validations.Models
{
    public class Login
    {
        [Key]
        [StringLength(50)]
        [DataType(DataType.EmailAddress,ErrorMessage ="Error Wrong Email")]
        public string Email { get; set; }
        [Display(Name ="User Name")]
        [StringLength(50),MinLength(3,ErrorMessage ="Min 3 characters are required")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [StringLength(50), MinLength(3, ErrorMessage = "Min 3 characters are required")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [StringLength(50), MinLength(3, ErrorMessage = "Min 3 characters are required")]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Password not matched")]
        public string CPassword { get; set; }
    }
}
