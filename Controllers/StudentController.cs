using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class StudentController : Controller
    {
        StudentContext db; 
        public StudentController(StudentContext context) 
        { 
            db = context;
        } 
        public async Task<IActionResult> Index() 
        {
            IEnumerable<Student> students = await Task.Run(() => db.Students); 
            return View(students); 
        } 

       
    }
}

