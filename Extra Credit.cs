using System;

class Program
{
    static void Main()
    {
        // User Input
        Console.Write("Please input a year:");
        int year = Convert.ToInt32(Console.ReadLine());

        // Leap Year Check
        bool isLeapYear = IsLeapYear(year);

        // Display the result
        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a Leap Year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year.");
        }
    }

    static bool IsLeapYear(int year)
    {
        // Leap year math
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }

        // ChatGPT. 2023, Jan 23. "Im lost on what to do for the math calulcations for leap year, what and how should I start out with"

        // ChatGPT. 2023, Jan 23. "How it's not outputting right how can I integrate it with the prior code"
    }   
}