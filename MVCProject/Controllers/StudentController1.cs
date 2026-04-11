using Microsoft.AspNetCore.Mvc;
using MVCProject.Data.Context;
using MVCProject.Models;
using MVCProject.Models.BusinessLogic;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
        public IActionResult Index()
        {
            List<Student> Students = studentBL.GetAll();
            return View("Index", Students);
        }



        public IActionResult Details(int id ) { 
           Student student = studentBL.GetById(id);
           return View("Details",student);
        }


        public IActionResult Add() {
            return View("Add");
        }

        [HttpPost]
        public IActionResult SaveAdd(Student newStudent) {

            if (newStudent.Name != null) {

                studentBL.Add(newStudent);
                return RedirectToAction(nameof(Index));
            }
            return View("Add" , newStudent);

        }

        public IActionResult Delete(int id) { 
            studentBL.Delete(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
