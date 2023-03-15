using System;
public class Course
{
    public string name;
    public string code;
    public int marks;
    public Course(string name, string code)
    {
        this.name = name;
        this.code = code;
    }
    public void Result()
    {
        if(this.marks > 80)
        {
            Console.WriteLine("4GPA");
        }
        else if(this.marks > 70 && this.marks <= 79) 
        {
            Console.WriteLine("3.5GPA");
        }
        else if(this.marks > 60 && this.marks <= 69)
        {
            Console.WriteLine("3.0GPA");
        }
        else
        {
            Console.WriteLine("Fail");
        }

    }

}