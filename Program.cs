using System;
using System.Linq;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("sara", 111, 2019);
            Student st2 = new Student("amna", 21, 2017);
            Student st3 = new Student("hamna", 19, 2015);
            Course course1 = new Course("Physics", "PHY-204");
            Course course2 = new Course("Math", "MT-333");
            st1.AssignCourse(course1);
            st1.AssignCourse(course2);
            st3.AssignCourse(course1);
            University1 university = new University1("NED");
            university.StudentAdmmission(st1);
            university.StudentAdmmission(st2);
            university.StudentAdmmission(st3);

            st1.Exam(course1, 75);
            st3.Exam(course1, 70);
            Course c = st1.course.FirstOrDefault(i => i.code == course1.code);
            c.Result();
            

            
        }
    }
}
