using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BIGSCHOOL.Models
{
    public class Attendance
    {
        public Course Course { get; set; }

        [Key]
        public int CourseId { get; set; }

        public ApplicationUser Attendee { get; set; }

        [Key]
        public string AttendeeId { get; set; }



    }
}