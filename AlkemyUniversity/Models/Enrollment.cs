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
        public int ? UserID{ get; set; }

        public virtual Course Course { get; set; }
       // public virtual Student Student { get; set; }
    }
}