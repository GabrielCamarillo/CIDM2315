using System;

class NumberTriangle
{
    static void Main()
    {
        Console.Write("Assign an int value to N: ");
        int n;

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


            // ChatGPT. 2023, Jan 30. "How can do it in decending order of my output"
        }
    }
}
