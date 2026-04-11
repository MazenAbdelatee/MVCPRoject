using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Data.Context;

namespace MVCProject.Models.BusinessLogic
{
    public class DepartmentBL
    {
        SchoolDbContext Context = new SchoolDbContext();


        public List<Department> ShowAllDept() {

            return Context.Departments.ToList();
        }

        public Department ShowDeptDetails(int id) {
            return Context.Departments
            .Include(D => D.Students)
            .FirstOrDefault(D => D.Id == id);
        }

        public void AddDept(Department NewDept) {
            Context.Add(NewDept);
            Context.SaveChanges();
        }
        public void RemoveDept(int id) {
            Department target = Context.Departments.Find(id);
            Context.Remove(target);
            Context.SaveChanges();
        }
    }
}
