using System;

class Student
{
    int rollNo;
    string name;
    double marks;
    string grade;

    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }

    public Student(int r, string n, double m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    public void CalculateGrade()
    {
        if (marks >= 75)
            grade = "A";
        else if (marks >= 60)
            grade = "B";
        else if (marks >= 50)
            grade = "C";
        else
            grade = "Fail";
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.CalculateGrade();
        s1.Display();

        Student s2 = new Student(1, "Rahul", 78);
        s2.CalculateGrade();
        s2.Display();
    }
}