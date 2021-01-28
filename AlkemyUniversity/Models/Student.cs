using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlkemyUniversity.Models
{
    public class Student
    {
        public string ID { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}