using System;

class SquarePattern
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

        PrintSquarePattern(n);
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
}