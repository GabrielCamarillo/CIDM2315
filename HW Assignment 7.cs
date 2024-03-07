using System;

public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }

    public string CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            return this.cus_name;
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            return objCustomer.cus_name;
        }
        else
        {
            return "Both customers are of the same age";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        customer1.ChangeID(220);
        customer2.ChangeID(221);

        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        string olderCustomer = customer1.CompareAge(customer2);
        if (olderCustomer != "Both customers are of the same age")
        {
            Console.WriteLine($"{olderCustomer} is older");
        }
        else
        {
            Console.WriteLine(olderCustomer);
        }
    }

    // ChatGPT. 2024, March 7. "Method used to change customer ID isn't doing it right and causing an error, whats the problem?"
}
