using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

public class AccountCreate{
    private string accountChoice;
    public Account SelectAccount() {

        Console.WriteLine("The types of accounts are:");
        Console.WriteLine(" 1. Checking Account");
        Console.WriteLine(" 2. Savings Account");
        Console.Write("Which type of account would you like to create? ");
        accountChoice = Console.ReadLine();
        
        Account account = null;

        switch(accountChoice)
        {
            case "1":
                account = CreateChecking();
                break;
            case "2":
                account = CreateSavings();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        return account;
    }
    public int RandAccountNum() {

        Random random = new Random();
        return random.Next(1000000, 1000000000);

    }
    public Account CreateChecking() {
        int accountNumber = RandAccountNum(); 
        Console.WriteLine("How much would you like to deposit? ");
        int balance = int.Parse(Console.ReadLine());
        Console.WriteLine();  
        
        return new AccountChecking(accountNumber, balance);
    }

    public Account CreateSavings() {
        int accountNumber = RandAccountNum(); 
        Console.WriteLine("How much would you like to deposit? ");
        int balance = int.Parse(Console.ReadLine());
        Console.WriteLine();   

        return new AccountSavings(accountNumber, balance);
    }
}

        