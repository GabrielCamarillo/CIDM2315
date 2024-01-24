using System;

class Program
{
    static void Main()
    {
        // User Input 
        Console.Write("Please input the first num:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the second num:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the thrid num:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        // Find Smallest Value
        int smallest = num1;

        if (num2 < smallest)
        {
            smallest = num2;
        }

        if (num3 < smallest)
        {
            smallest = num3;
        }

        // Display Smallest Number
        Console.WriteLine($"The smallest value is: {smallest}");

        // ChatGPT. 2023, Jan 23. "My if statements arent working correctly can you try to show me the correct process"

        // ChatGPT. 2023, Jan 23. "The printing value is not showing at the end"
    }
} 