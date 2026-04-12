using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Data.Context;

namespace MVCProject.Models.BusinessLogic
{
    public class StudentBL
    {
        SchoolDbContext Context = new SchoolDbContext();


        public List<Student> GetAll() {

            return Context.Students.ToList();
        }

        public Student GetById(int id) {
            return Context.Students.Include(S => S.Department).FirstOrDefault(S => S.Id == id);
        }

        public void Add (Student NewStudent) {
            Context.Add(NewStudent);
            Context.SaveChanges();
        }
        public void Delete(int id) {
            Student Target = GetById(id);
            Context.Students.Remove(Target);
            Context.SaveChanges();
        }


        public void Update(Student UpdatedStudent) {
            Context.Update(UpdatedStudent);
            Context.SaveChanges();
        }

    }
}
