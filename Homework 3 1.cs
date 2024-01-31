using System;
class Program
{
    static void Main()
    {
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

        // ChatGPT. 2023, Jan 30. "My 'for' line isn't working correctly giving me answer, what is the error"
    }
}