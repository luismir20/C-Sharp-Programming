using System;

class Bank
{
    private string name;
    private int accountNumber;
    private double balance;

    public Bank(string name, int accountNumber, double balance)
    {
        this.name = name;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposit of {0:C} successful. New balance is {1:C}.", amount, balance);
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("Withdrawal of {0:C} successful. New balance is {1:C}.", amount, balance);
        }
        else
        {
            Console.WriteLine("Withdrawal of {0:C} failed. Insufficient funds.", amount);
        }
    }

    public void Display()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Account number: {0}", accountNumber);
        Console.WriteLine("Balance: {0:C}", balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bank myBank = new Bank("John Smith", 123456, 1000.00);
        myBank.Display();
        myBank.Deposit(500.00);
        myBank.Withdraw(200.00);
        myBank.Withdraw(1500.00);
        Console.ReadKey();
    }
}
