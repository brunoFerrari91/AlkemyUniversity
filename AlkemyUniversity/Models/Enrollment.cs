using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlkemyUniversity.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public string StudentID{ get; set; }

        public virtual Course Course { get; set; }
    }
}