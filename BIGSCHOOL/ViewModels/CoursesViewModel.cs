﻿using BIGSCHOOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIGSCHOOL.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourse { get; set; }
        public bool ShowAction { get; set; }
    }
}