using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");

        Console.Write("Number 1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Number 2: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Number 3: ");
        int num3 = int.Parse(Console.ReadLine());

        int[] numbers = { num1, num2, num3 };
        Array.Sort(numbers);

        Console.WriteLine("Numbers in ascending order:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
