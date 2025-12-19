// See https://aka.ms/new-console-template for more information
// write code to find prime numbers between 1 to 100. ask user to enter input
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the upper limit to find prime numbers (greater than 1): ");
        int upperLimit;
        while (!int.TryParse(Console.ReadLine(), out upperLimit) || upperLimit <= 1)
        {
            Console.WriteLine("Invalid input. Please enter a number greater than 1:");
        }

        Console.WriteLine($"Prime numbers between 1 and {upperLimit} are:");
        for (int num = 2; num <= upperLimit; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
