public class Menu
{
    bool running = true;
    List<Account> accounts = new List<Account>();
    AccountLogin accountLogin = new AccountLogin();
    AccountCreate accountCreate = new AccountCreate();
    AccountDisplay accountDisplay = new AccountDisplay();
    AccountTransfer accountTransfer = new AccountTransfer();

    // Welcomes user as "Guest"
    User currentUser = new User("Guest", "Account", "username", "password");
    bool isLoggedIn = false;
    public void Main()
    {   
        AccountSave accountSave = new AccountSave(this);
        
        while (running) 
        {   
            Console.Clear();
            Console.WriteLine($"Welcome, {currentUser.GetFirstName()}!"); 
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Log In");
            Console.WriteLine(" 2. Open Bank Account");
            Console.WriteLine(" 3. Display Balance");
            Console.WriteLine(" 4. Transfer Funds");
            Console.WriteLine(" 5. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Displays log-in prompt and updates current user info
                    var loginResult = accountLogin.LogInPrompt();
                    if (loginResult.Item1 != null) {
                        currentUser = loginResult.Item1;
                        accounts = loginResult.Item2;
                        isLoggedIn = true;
                    }
                    else {
                        Console.WriteLine("Invalid login credentials. Please try again.");
                        Console.ReadLine();
                    }
                    break;

                case "2": 
                    if (isLoggedIn) { 
                        // If logged in, user can add new account, 1 checking, 3 savings
                        if (CanCreateNewAccount(accounts, accountCreate.GetAccountChoice()))
                        {
                            Account newerAccount = accountCreate.SelectAccount();
                            accounts.Add(newerAccount);
                            // Serializes account information
                            accountSave.SerializetoJson(accounts, currentUser);
                        }
                        else
                        {
                            Console.WriteLine("Account creation limit reached. Cannot create more accounts of this type.");
                            Console.ReadLine();
                        }
                    } 
                    else { // Guest user can make a new user and bank account
                        User newUser = CreateUser();
                        Account newAccount = accountCreate.SelectAccount();
                        accounts.Add(newAccount);
                        // Serializes account information
                        accountSave.SerializetoJson(accounts, newUser);
                    }
                    break;

                case "3":
                    if (!isLoggedIn) {
                        Console.WriteLine("Please log in or become a member today to use this feature!");
                        Console.ReadLine();
                        break;
                    }  
                    // User has to be logged in to display their account balances
                    accountDisplay.ListInfo(accounts, currentUser);
                    break;

                case "4":
                    if (!isLoggedIn) {
                        Console.WriteLine("Please log in or become a member today to use this feature!");
                        Console.ReadLine();
                        break;
                    } 
                    // User has to be logged in to transfer funds
                    accountTransfer.TransferFunds(accounts);
                    // Serializes account information
                    accountSave.SerializetoJson(accounts, currentUser);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private bool CanCreateNewAccount(List<Account> accounts, string accountChoice)
    {
        int checkingCount = accounts.Count(a => a is AccountChecking);
        int savingsCount = accounts.Count(a => a is AccountSavings);

        if (accountChoice == "1" && checkingCount >= 1)
        {
            return false; // Limit of 1 checking account
        }

        if (accountChoice == "2" && savingsCount >= 3)
        {
            return false; // Limit of 3 savings accounts
        }

        return true;
    }
    public User CreateUser() {
        Console.WriteLine("Enter first name:  ");
        string firstName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Create a username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Create a password: ");
        string password = Console.ReadLine();

        return new User(firstName, lastName, username, password);
    }
}