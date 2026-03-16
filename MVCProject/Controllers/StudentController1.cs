using Microsoft.AspNetCore.Mvc;
using MVCProject.Data.Context;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> Students = studentBL.GetAll();
            return View("Index", Students);;
        }

        public IActionResult Details(int id ) { 
           StudentBL studentBL=new StudentBL();
           Student student = studentBL.GetById(id);
           return View(student);
        }
    }
}
