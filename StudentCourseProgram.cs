using System;

class Student
{
    private string name;
    private int age;
    private double gpa;

    public Student(string name, int age, double gpa)
    {
        this.name = name;
        this.age = age;
        this.gpa = gpa;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public double GetGPA()
    {
        return gpa;
    }

    public void Display()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("GPA: {0}", gpa);
    }
}

class Course
{
    private string name;
    private Student[] students;

    public Course(string name, Student[] students)
    {
        this.name = name;
        this.students = students;
    }

    public void Display()
    {
        Console.WriteLine("Course name: {0}", name);
        Console.WriteLine("Students enrolled:");
        foreach (Student student in students)
        {
            Console.WriteLine("- {0}, age {1}, GPA {2}", student.GetName(), student.GetAge(), student.GetGPA());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[]
        {
            new Student("John Smith", 20, 3.5),
            new Student("Jane Doe", 22, 4.0),
            new Student("Bob Johnson", 19, 3.2)
        };

        Course myCourse = new Course("Introduction to Computer Science", students);
        myCourse.Display();
        Console.ReadKey();
    }
}
