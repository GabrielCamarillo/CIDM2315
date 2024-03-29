using System;
using System.Collections.Generic;

class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public int StudentID // Public Student ID
    {
        get { return studentID; }
        set { studentID = value; }
    }

    public string StudentName // Public Name
    {
        get { return studentName; }
        set { studentName = value; }
    }

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Q2: Student Name ID
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        // Q3 Gradebook Dictionary
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        // Add Tom If Missing
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        // Calculate Average GPA
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA:F2}");

        // Print Higher Average GPA
        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.StudentName) && gradebook[student.StudentName] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
   // ChatGPT. 2024, March 26. "My output has an error cause of the public/private void, what went wrong?"
   // ChatGPT. 2024, March 26. "Its outputting the wrong GPA thats higher than the average, where does the mistake occur at?"
}
