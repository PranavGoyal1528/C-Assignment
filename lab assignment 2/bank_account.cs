using System;

class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Details:");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder Name: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}

class bank_account
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123456789", "Pranav Goyal", 1000.0);

        account.DisplayAccountDetails();

        account.Deposit(500.0);
        account.Withdraw(200.0);
        account.Withdraw(1500.0);

        account.DisplayAccountDetails();
    }
}
