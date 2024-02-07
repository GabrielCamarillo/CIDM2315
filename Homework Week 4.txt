using System;

class Program
{
    static void Main()
    {
        // Input
        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b = int.Parse(Console.ReadLine());

        // Method for number
        int largestNumber = FindLargestNumber(a, b);

        // Print largest number
        Console.WriteLine($"a = {a}; b = {b} \t The largest number is: {largestNumber}");

        // Input for for shape
        Console.WriteLine("Enter an integer N:");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Is the shape left or right:");
        string shape = Console.ReadLine().ToLower();

        if (shape == "left")
        {
            PrintLeftTriangle(N);
        }
        else if (shape == "right")
        {
            PrintRightTriangle(N);
        }
        else
        {
            Console.WriteLine("Invalid shape input!");
        }
    }

    // Method for large number
    static int FindLargestNumber(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    // Left triangle
    static void PrintLeftTriangle(int N)
    {
        Console.WriteLine($"N is: {N}; shape is left");

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Right triangle
    static void PrintRightTriangle(int N)
    {
        Console.WriteLine($"N is: {N}; shape is right");

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // ChatGPT. 2024, Feb 6. "My right and left values arent working, how can I can add an input so it could output left or right from user input"
}