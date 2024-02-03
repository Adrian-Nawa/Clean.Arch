using CleanArch.Domain.Interfices;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private TestDb _tdb;
        public CourseRepository(TestDb test)
        {
            _tdb = test;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _tdb.Courses;
        }
    }
}
