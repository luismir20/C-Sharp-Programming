using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        Console.WriteLine("Random number: {0}", randomNumber);
        Console.ReadKey();
    }
}
