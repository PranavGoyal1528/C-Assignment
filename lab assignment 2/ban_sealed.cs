using System;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
}

public sealed class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public double CalculateInterest()
    {
        return Balance * InterestRate / 100;
    }
}

class bank_sealed
{
    static void Main(string[] args)
    {
        SavingsAccount savingsAccount = new SavingsAccount
        {
            AccountNumber = "123456789",
            Balance = 1000.0,
            InterestRate = 5.0
        };

        double interest = savingsAccount.CalculateInterest();
        Console.WriteLine($"Interest: {interest:C}");
    }
}
