public class University1
{
    public string name;
    public Student[] students;
    public int noOfStudents;
    public string department;

    public University1(string name, string department)
    {
        this.name = name;
        this.department = department;
        this.students = new Student[20];  
    }
    public void AssignStudent(Student student)
    {
        this.students[noOfStudents] = student;
        noOfStudents++;
    }

}