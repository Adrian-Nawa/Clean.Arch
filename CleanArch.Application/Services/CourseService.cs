using CleanArch.Application.Interfices;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseServices
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses=_courseRepository.GetCourses()
            };
        }
    }
}
