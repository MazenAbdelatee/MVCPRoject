using MVCProject.Data.Context;

namespace MVCProject.Models
{
    public class StudentBL
    {
        SchoolDbContext Context = new SchoolDbContext();


        public List<Student> GetAll() {

            return Context.Students.ToList();
        }

        public Student GetById(int id) {

           return Context.Students.FirstOrDefault(S => S.Id == id);

        }
    }
}
