﻿using CleanArch.Application.Interfices;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfices;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseServices,CourseService>();

            //Infra Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}