using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Models.BusinessLogic;
namespace MVCProject.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentBL deptBL = new DepartmentBL();

        [HttpGet]
        public IActionResult Index() {
            List < Department > DeptList = deptBL.ShowAllDept();
            return View("Index",DeptList);
        
        }


        [HttpGet]
        public IActionResult DepartmentDetail(int id) {

            Department TargetDept = deptBL.ShowDeptDetails(id);

            return View("DepartmentDetail", TargetDept);

        }

        public IActionResult Add() { 
        
            return View("Add");
        }

        [HttpPost]
        public IActionResult SaveAdd(Department DeptSent) {
            if (DeptSent.Name != null) {
                deptBL.AddDept(DeptSent);

                return RedirectToAction(nameof(Index));
            }
            return View("Add", DeptSent);
        
        }

        public IActionResult DeleteDept(int id) { 
        
            deptBL.RemoveDept(id);
            return RedirectToAction(nameof(Index));
        
        }

        
    }
}
