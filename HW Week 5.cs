using System;

class Program
{
    static void Main(string[] args)
    {
        // Part One
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int largest1 = GetLargest(num1, num2);
        Console.WriteLine($"a = {num1}; b = {num2}");
        Console.WriteLine($"The largest number is: {largest1}");

        // Part Two
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the fourth number:");
        int d = Convert.ToInt32(Console.ReadLine());

        int max1 = GetLargest(a, b);
        int max2 = GetLargest(c, d);
        int largest2 = GetLargest(max1, max2);

        Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}");
        Console.WriteLine($"The largest number is: {largest2}");

        // Part Three
        createAccount();
    }

    static int GetLargest(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }

    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Your Password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again:");
        string password2 = Console.ReadLine();

        Console.WriteLine("Enter Your Birthyear:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
        }
        else
        {
            Console.WriteLine("Could not create account");
        }
    }

    // ChatGPT. 2024, Feb 13. "How can I integrate the first method so that it outputs, correctly since mine is doing it wrong"
    // ChatGPT. 2024, Feb 13. "Its repeating the same first two values, whats the error in code thats creating this"
}
