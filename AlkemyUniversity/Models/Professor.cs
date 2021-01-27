using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlkemyUniversity.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        public int CourseID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int DNI { get; set; }
        //public Boolean Is_Working { get; set; }

        public virtual Course Course { get; set; }
    }
}