using System. Linq;
using System.Collections.Generic;
public class Student
{
    public string name;
    public int rollNo;
    public int batch;
    public LinkedList<Course> course = new LinkedList<Course>();
    public Student(string name, int rollNo, int batch)
    {
        this.name = name;
        this.rollNo = rollNo;
        this.batch = batch;
    } 
    public void AssignCourse(Course course)
    {
        Course c = new Course(course.name, course.code);
        this.course.AddLast(c);
    }
    public void DropCourse(Course course)
    {
        // this.course.;
    }
    
    public void Exam(Course course, int marks)
    {
        Course c = this.course.FirstOrDefault(i => i.code == course.code);
        c.marks = marks;
    }
}