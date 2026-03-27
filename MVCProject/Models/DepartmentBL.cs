using MVCProject.Data.Context;

namespace MVCProject.Models
{
    public class DepartmentBL
    {
        SchoolDbContext Context = new SchoolDbContext();


        // show all action 
        public List<Department> ShowAll() {
            return Context.Departments.ToList();
        }

        // showDetails
        public Department GetDeptDetails(int id) {
            return Context.Departments.FirstOrDefault(D => D.Id == id);
        }


        public void AddDept(Department deptSent)
        {
            Context.Departments.Add(deptSent);

            Context.SaveChanges();
        }
    }
}
