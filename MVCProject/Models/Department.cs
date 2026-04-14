using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Required")]
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^a~zA~Z$")]
        public string Name { get; set; }
        [Display(Name = "Manager Name")]
        [Required(ErrorMessage = "Please Enter The Manager Name ")]
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^a~zA~Z$")]
        public string MgrName { get; set; }


        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }


    }
}
