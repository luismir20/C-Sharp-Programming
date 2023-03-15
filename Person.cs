using System;

class Person
{
    private string name;
    private int age;
    private string address;

    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public void Display()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Address: {0}", address);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person myPerson = new Person("John Smith", 30, "123 Main Street");
        myPerson.Display();
        Console.ReadKey();
    }
}
