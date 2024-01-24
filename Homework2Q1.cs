using System;

class Program
{
    static void Main()
    {
        // User Input Grade
        Console.Write("Please input a letter grade:");
        string inputLetter = Console.ReadLine().ToUpper();

        // Determine GPA Point
        int gpaPoint;
        switch (inputLetter)
    {
            case "A":
                gpaPoint = 4;
                break;
            case "B":
                gpaPoint = 3;
                break;
            case "C":
                gpaPoint = 2;
                break;
            case "D":
                gpaPoint = 1;
                break;
            case "F":
                gpaPoint = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return;
        }

        // Final GPA Point
        Console.WriteLine($"GPA Point {inputLetter}: {gpaPoint}");

        // ChatGPT. 2023, Jan 23. "It's not switching/reading my letter correctly how can i fix it"
    }
} 