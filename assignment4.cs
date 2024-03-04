using System;

class Program
{
    static void Main(string[] args)
    {
        float[] alpha = new float[50];

        for (int i = 0; i < 50; i++)
        {
            alpha[i] = (i < 25) ? i * i : 3 * i; 
        }

        for (int i = 0; i < 50; i++)
        {
            Console.Write(alpha[i] + " ");
            if ((i + 1) % 10 == 0) 
                Console.WriteLine();
        }
    }
}
