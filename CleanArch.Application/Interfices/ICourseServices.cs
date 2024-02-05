﻿using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfices
{
    public interface ICourseServices
    {
        CourseViewModel GetCourses();
        Course GetCourseById(int courseid);
    }
}
