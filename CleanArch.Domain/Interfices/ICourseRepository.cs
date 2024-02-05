using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfices
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        Course GetCourseById(int courseid);
    }
}
