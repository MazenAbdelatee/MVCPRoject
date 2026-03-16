using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Degree { get; set; }
        public byte MinDegree { get; set; }



        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }


        public List<Teacher> Teachers { get; set; }
        public List<StuCrs> StuCrses { get; set; }

    }
}
