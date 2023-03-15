public class Student
{
    public string name;
    public int rollNo;
    public int batch;
    public Course[] courses;
    public int noOfCourses;
    public Student(string name, int rollNo, int batch)
    {
        this.name = name;
        this.rollNo = rollNo;
        this.batch = batch;
        this.courses = new Course[10];
    } 
    public void AssignCourses(Course course)
    {
        this.courses[noOfCourses] = course;
        noOfCourses++;
    }
    
}