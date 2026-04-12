using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCProject.Data.Context;
using MVCProject.Models;
using MVCProject.Models.BusinessLogic;
using MVCProject.ViewModels;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
        DepartmentBL departmentBL = new DepartmentBL();
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

            StudentWithExtraInfoViewModel studentVM = new StudentWithExtraInfoViewModel
            {
                Departments = departmentBL
                .ShowAllDept()
                .Select(D => new SelectListItem { 
                    Text = D.Name , 
                    Value = D.Id.ToString() })
                .ToList(),

            }; 

            return View(studentVM);
            //return View("Add");
        }



        [HttpPost]
        public IActionResult SaveAdd(StudentWithExtraInfoViewModel newStudent) {

            if (ModelState.IsValid) {
                Student student = new Student
                {
                    Name = newStudent.StudentName,
                    Age = newStudent.Age,
                    DepartmentId = newStudent.DeptId
                };
                studentBL.Add(student);
                return RedirectToAction(nameof(Index));
            }
            newStudent.Departments = departmentBL
                .ShowAllDept()
                .Select(D => new SelectListItem
                {
                    Text = D.Name,
                    Value = D.Id.ToString()
                })
                .ToList();

            return View( "Add" , newStudent);

        }

        public IActionResult Delete(int id) { 
            studentBL.Delete(id);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(int id) {
            Student OldStudent = studentBL.GetById(id);

            StudentWithExtraInfoViewModel UpdatedStudent = new StudentWithExtraInfoViewModel {
                Id = OldStudent.Id,
                StudentName = OldStudent.Name,
                Age = OldStudent.Age,
                DeptId = OldStudent.DepartmentId,
                Departments = departmentBL
                .ShowAllDept()
                .Select(d => new SelectListItem {
                    Text = d.Name,
                    Value = d.Id.ToString() })
                .ToList()
            };
            
            return View(UpdatedStudent);
        }


        [HttpPost]
        public IActionResult SaveEdit(StudentWithExtraInfoViewModel UpdatedStudent) {

            if (ModelState.IsValid) {

                Student s = new Student { Id = UpdatedStudent.Id
                    ,Name = UpdatedStudent.StudentName
                    ,Age = UpdatedStudent.Age
                    , DepartmentId = UpdatedStudent.DeptId 
                };
                studentBL.Update(s);
                return RedirectToAction(nameof(Index));
            }

            UpdatedStudent.Departments = departmentBL.ShowAllDept()
                                                    .Select(d => new SelectListItem
                                                    {
                                                        Text = d.Name,
                                                        Value = d.Id.ToString()
                                                    }).ToList();

            return View("Add",UpdatedStudent);


        }


    }
}
