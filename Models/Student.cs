using System.ComponentModel.DataAnnotations;

namespace Validations.Models
{
    public enum Gender
    {
        Male, Female, Other
    }
    public class Student
    {
        
        public int StudentId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage ="Type your name")]
        [MinLength(5,ErrorMessage ="must type 2 words")]
        [Display(Name ="Student Name")]
        public string SName { get; set; }
        [StringLength(50)]
        [Display(Name = "Father Name")]
        public string FName { get; set; }
        public Gender gender { get; set; }
        [Display(Name = "Date of Admission")]
        public DateTime DOA { get; set; }
        [StringLength(250)]
        public string Address { get; set; }

        //[Range(5, 50, ErrorMessage = "Age Must be between 5 to 20")]
    }
}
