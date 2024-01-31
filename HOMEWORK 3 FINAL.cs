using System;

class Program
{
    static void Main()
    {
        // Question 1
        Console.Write("Input an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"N is prime.");
        }
        else
        {
            Console.WriteLine($"N is non-prime.");
        }

        // Question 2
        Console.Write("Assign an int value to N: ");
        int n;

        // Checking
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }

        PrintSquarePattern(n);

        // Question 3
        Console.Write("Assign an int value to N: ");

        // Checking
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }

        PrintTrianglePattern(n);

        // Extra Credit
        Console.Write("Assign an int value to N: ");

        // Checking
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        // Print in triangle
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }

            Console.WriteLine(); // Move to the next line after completing a row
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void PrintSquarePattern(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("# ");
            }

            Console.WriteLine(); // Move to the next line after completing a row
        }
    }

    static void PrintTrianglePattern(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows; j++)
            {
                if (j <= i)
                {
                    Console.Write("* ");
                }
            }

            Console.WriteLine(); // Move to the next line after completing a row
        }
    }
    // Question 1 ChatGPT. 2023, Jan 30. "My 'for' line isn't working correctly giving me answer, what is the error"
    // Question 3 ChatGPT. 2023, Jan 30. "My outputs are misaligning, where is my error"
    // Extra Credit ChatGPT. 2023, Jan 30. "How can do it in decending order of my output"
}
