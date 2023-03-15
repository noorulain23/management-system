using System.Collections.Generic;
public class University1
{
    public string name;
    public LinkedList<Student> student = new LinkedList<Student>();
    public  LinkedList<string> department = new LinkedList<string>();

    public University1(string name)
    {
        this.name = name;
    }
    public void StudentAdmmission(Student student)
    {
       this.student.AddLast(student);
    }

}