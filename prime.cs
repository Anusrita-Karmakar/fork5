using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter a number to check if it's prime: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
            Console.WriteLine($"{number} is a prime number.");
        else
            Console.WriteLine($"{number} is not a prime number.");

        Console.WriteLine("\nPrime numbers between 1 and 100:");
        for (int i = 2; i <= 100; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
