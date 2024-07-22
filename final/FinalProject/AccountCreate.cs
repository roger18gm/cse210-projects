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
        // Tree to determine if account type is Checking or Savings
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

    // Method to generate a random 9 digit account number
    public int RandAccountNum() {

        Random random = new Random();
        return random.Next(1000000, 1000000000);

    }

    // Creates instance of AccountChecking
    public Account CreateChecking() {
        int minAmount = 0;
        while (minAmount < 100) {
            Console.WriteLine("How much would you like to deposit? (Minimum $100): ");
            minAmount = int.Parse(Console.ReadLine());
            if (minAmount < 100) {
                Console.WriteLine("The minimum deposit for a checking account is $100. Please enter a valid amount.");
            }
        }
        int accountNumber = RandAccountNum();
        return new AccountChecking(accountNumber, minAmount);
    }

    // Creates instance of AccountSavings
    public Account CreateSavings() {
        int minAmount = 0;
        while (minAmount < 200) {
            Console.WriteLine("How much would you like to deposit? (Minimum $200): ");
            minAmount = int.Parse(Console.ReadLine());
            if (minAmount < 200) {
                Console.WriteLine("The minimum deposit for a savings account is $200. Please enter a valid amount.");
            }
        }
        int accountNumber = RandAccountNum();
        return new AccountSavings(accountNumber, minAmount);
    }
    public string GetAccountChoice() {
        return accountChoice;
    }
}

        