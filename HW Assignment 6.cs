using System;

public class Professor
{
    private string profName;
    private string classRoom;
    private double salary;

    public Professor(string name, string course, double salary)
    {
        this.profName = name;
        this.classRoom = course;
        this.salary = salary;
    }

    public void SetSalary(double salary_amount)
    {
        this.salary = salary_amount;
    }

    public double GetSalary()
    {
        return this.salary;
    }

    public string GetName()
    {
        return this.profName;
    }

    public string GetCourse()
    {
        return this.classRoom;
    }
}

public class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string name, string course, double grade)
    {
        this.studentName = name;
        this.classEnroll = course;
        this.studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        this.studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return this.studentGrade;
    }

    public string GetName()
    {
        return this.studentName;
    }

    public string GetCourse()
    {
        return this.classEnroll;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Professor professor1 = new Professor("Alice", "Java", 9000);
        Professor professor2 = new Professor("Bob", "Math", 8000);

        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        Console.WriteLine($"Professor {professor1.GetName()} teaches {professor1.GetCourse()}, and the salary is: {professor1.GetSalary()}");
        Console.WriteLine($"Professor {professor2.GetName()} teaches {professor2.GetCourse()}, and the salary is: {professor2.GetSalary()}");
        Console.WriteLine($"Student {student1.GetName()} enrolls {student1.GetCourse()}, and the grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.GetName()} enrolls {student2.GetCourse()}, and the grade is: {student2.GetGrade()}");

        double salaryDifference = Math.Abs(professor1.GetSalary() - professor2.GetSalary());
        Console.WriteLine($"The salary difference between {professor1.GetName()} and {professor2.GetName()} is: {salaryDifference}");

        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"The total grade of {student1.GetName()} and {student2.GetName()} is: {totalGrade}");
    }

    // ChatGPT. 2024, Feb 27. "My salary info isn't doing the math/references right, what is the error that is being made?"
    // ChatGPT. 2024, Feb 27. "It is mixing up the two values I have for the salary?"

}
