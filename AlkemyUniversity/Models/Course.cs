using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlkemyUniversity.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title{ get; set; }
        public int Quota { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }

    }
}