using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class About
    {
       
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}