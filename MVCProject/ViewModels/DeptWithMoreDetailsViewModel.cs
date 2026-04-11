using MVCProject.Models;

namespace MVCProject.ViewModels
{
    public class DeptWithMoreDetailsViewModel 
    {
        public string DeptName { get; set; }

        public string MgrName { get; set; }

        public List<Student> Students { get; set; }
    }
}
