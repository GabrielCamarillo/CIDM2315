using System;

class TrianglePattern
{
    static void Main()
    {
        Console.Write("Assign an int value to N: ");
        int n;

        // Checking
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }

        PrintTrianglePattern(n);
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

            // ChatGPT. 2023, Jan 30. "My outputs are misaligning, where is my error"
        }
    }
}
