using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
namespace MVCProject.Controllers
{
    public class DepartmentController : Controller
    {
            DepartmentBL departmentBL = new DepartmentBL();
        public IActionResult Index()
        {
            List<Department> departments = departmentBL.ShowAll();
            return View("Index",departments);
        }


        public IActionResult Details(int id) {
            Department TargetDept = departmentBL.GetDeptDetails(id); 
            return View("Details", TargetDept);
        }
    }
}
