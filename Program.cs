using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("sara", 111, 2019);
            Student st2 = new Student("amna", 21, 2017);
            Course course1 = new Course("Physics");
            Course course2 = new Course("Math");
            st1.AssignCourses(course1);
            st1.AssignCourses(course2);
            University1 university = new University1("NED", "EL");
            university.AssignStudent(st1);
            university.AssignStudent(st2);

            
        }
    }
}
