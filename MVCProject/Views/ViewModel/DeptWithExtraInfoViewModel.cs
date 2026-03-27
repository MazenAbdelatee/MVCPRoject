using MVCProject.Models;

namespace MVCProject.Views.ViewModel
{
    public class DeptWithExtraInfoViewModel
    {
        public Department DepartmentName { get; set; }
        public List<Models.Student> Students { get; set; }
        public string State => Students.Capacity > 50 ? "main" : "branch";
    }
}
