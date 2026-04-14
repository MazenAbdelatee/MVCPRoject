using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "You must enter you name you are not a ghost ")]
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^a~zA~Z$")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You should be older than 14")]
        [Range(15,30,ErrorMessage = "You should be older than 14")]
        public int Age { get; set; }

        public List<StuCrs> StuCrses { get; set; }

        [ForeignKey("Department")]
        [Required(ErrorMessage = "Please Choose Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
