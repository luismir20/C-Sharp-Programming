using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\path\to\data.csv";
        string[] lines = File.ReadAllLines(filePath);
        
        // Get a list of distinct years
        int[] years = lines.Skip(1)
                           .Select(line => int.Parse(line.Split(',')[1]))
                           .Distinct()
                           .ToArray();
        
        // Pivot the data
        Console.WriteLine("Country\t" + string.Join("\t", years));
        foreach (string country in lines.Skip(1).Select(line => line.Split(',')[0]).Distinct())
        {
            Console.Write(country + "\t");
            foreach (int year in years)
            {
                string population = lines.FirstOrDefault(line => line.StartsWith(country + "," + year))?.Split(',')[2];
                Console.Write((population ?? "") + "\t");
            }
            Console.WriteLine();
        }
        
        Console.ReadKey();
    }
}
