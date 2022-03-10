using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Uni
{
    public class University : Institute
    {
        public Student[] Students { get; }
        public Course[] Courses { get; }
        public Grade[] Grades { get; }
        public Schedule[] ScheduledCourses { get; }
        public University()
        {
            Students = new Student[30];
            Courses = new Course[20];
            ScheduledCourses = new Schedule[60];
        }
        public Student[] GetStudents()
        {
            return Students;
        }
        public Course[] GetCourses()
        {
            return Courses;
        }
        public Grade[] GetGrades()
        {
            return Grades;
        }
        public void SetSchedule(Guid courseId, Guid professorId, DateTime dateTime)
        {
        }
    }
}