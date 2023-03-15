using System;

class Dog
{
    private string name;
    private int age;

    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Bark()
    {
        Console.WriteLine("{0} barks!", name);
    }

    public void Fetch(string item)
    {
        Console.WriteLine("{0} fetches the {1}!", name, item);
    }

    public void Sleep()
    {
        Console.WriteLine("{0} is sleeping zzzz...", name);
    }

    public void Birthday()
    {
        age++;
        Console.WriteLine("{0} just turned {1} years old!", name, age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Fido", 3);
        myDog.Bark();
        myDog.Fetch("ball");
        myDog.Sleep();
        myDog.Birthday();
        Console.ReadKey();
    }
}
