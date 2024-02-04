using CleanArch.Application.Interfices;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseServices _courseServices;
        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }
        public IActionResult Index()
        {
            CourseViewModel model=_courseServices.GetCourses();
            return View(model);
        }
    }
}
