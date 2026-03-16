using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  decimal Salary { get; set; }
        public string Address { get; set; }




        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Course")]
        public int CoursetId { get; set; }
        public Course Course { get; set; }
    }
}
