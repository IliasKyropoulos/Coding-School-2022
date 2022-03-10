using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Uni
{
    public class Professor : Person
    {
        public string Rank { get; set; }
        public Course[] Courses { get; set; }
        public Professor()
        {
        }
        public void Teach(Course course, DateTime date)
        {
        }
        public void SetGrade(Guid studentId, Guid courseId, int grade)
        {
        }
        public new string GetName()
        {
            return "Dr." + Name;
        }
    }
}