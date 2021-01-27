using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlkemyUniversity.Models
{
    public enum Workweek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public int CourseID { get; set; }
        public Workweek Day { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public virtual Course Course { get; set; }
    }
}