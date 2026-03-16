using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class StuCrs
    {

        public int Grade { get; set; }

        [ForeignKey("Course")]
        public int CoursetId { get; set; }
        public Course Course { get; set; }



        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
