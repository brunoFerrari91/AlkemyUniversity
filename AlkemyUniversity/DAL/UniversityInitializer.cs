using AlkemyUniversity.Models;
using System;
using System.Collections.Generic;

namespace AlkemyUniversity.DAL
{
    public class UniversityInitializer: System.Data.Entity. DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            base.Seed(context);
        }
        /*protected override void Seed(UniversityContext context)
        {
            var students = new List<Student>
            {
                new Student(),
                new Student(),
                new Student()
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            
            var courses = new List<Course>
            {
                new Course{Title="Física",Quota=10,Description="Materia de 1er año"},
                new Course{Title="Matemáticas",Quota=15,Description="Materia del curso de ingreso"},
                new Course{Title="Química",Quota=10,Description="Materia de 1er año"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{CourseID=1},
                new Enrollment{CourseID=1},
                new Enrollment{CourseID=2},
                new Enrollment{CourseID=3}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            var schedules = new List<Schedule>
            {
                new Schedule{CourseID=1,Day=Workweek.Monday,Start=new TimeSpan(16,0,0),End=new TimeSpan(18,0,0)},
                new Schedule{CourseID=1,Day=Workweek.Wednesday,Start=new TimeSpan(16,0,0),End=new TimeSpan(18,0,0)},
                new Schedule{CourseID=2,Day=Workweek.Tuesday,Start=new TimeSpan(14,30,0),End=new TimeSpan(19,30,0)},
                new Schedule{CourseID=3,Day=Workweek.Saturday,Start=new TimeSpan(9,0,0),End=new TimeSpan(11,0,0)}
            };
            schedules.ForEach(s => context.Schedules.Add(s));
            context.SaveChanges();

            var professors = new List<Professor>
            {
                new Professor{CourseID=1,First_Name="Pedro",Last_Name="Perez",DNI=11111,Is_Working=true},
                new Professor{CourseID=2,First_Name="Pablo",Last_Name="Martinez",DNI=22222,Is_Working=true},
                new Professor{CourseID=3,First_Name="Juan",Last_Name="Lopez",DNI=33333/*,Is_Working=true},
               // new Professor{First_Name="Joaquin",Last_Name="Gonzalez",DNI=44444,Is_Working=false}
            };
            professors.ForEach(s => context.Professors.Add(s));
            context.SaveChanges();
        }*/
    }
}