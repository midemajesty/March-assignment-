using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");

        string inputString = Console.ReadLine();

        Console.WriteLine("String in uppercase:");
        Console.WriteLine(inputString.ToUpper());
    }
}
