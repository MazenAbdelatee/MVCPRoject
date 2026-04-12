using Microsoft.AspNetCore.Mvc.Rendering;
using MVCProject.Models;

namespace MVCProject.ViewModels
{
    public class StudentWithExtraInfoViewModel
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int DeptId { get; set; }

        public List<SelectListItem>? Departments { get; set; }


    }
}
