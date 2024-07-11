public class Menu
{
    bool running = true;
    private int balance = 0;
    List<Account> accounts = new List<Account>();
    AccountLogin accountLogin = new AccountLogin();
    AccountCreate accountCreate = new AccountCreate();
    AccountDisplay accountDisplay = new AccountDisplay();
    User currentUser = new User("Guest", "Account", "username", "password");
    // feature that prevents guest from using features that only logged in members can use; Loggedin bool?
    public void Main()
    {   
        AccountSave accountSave = new AccountSave(this);
        
        while (running) 
        {   
            Console.Clear();
            Console.WriteLine($"Welcome, {currentUser.GetFirstName()}!"); // welcome guest and then users first name
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
                case "1":
                    var loginResult = accountLogin.LogInPrompt();
                    currentUser = loginResult.Item1;
                    accounts = loginResult.Item2;
                    break;
                case "2":
                    User newUser = CreateUser();
                    Account newAccount = accountCreate.SelectAccount();
                    accounts.Add(newAccount);
                    accountSave.SerializetoJson(accounts, newUser);
                    break;
                case "3":
                    accountDisplay.ListInfo(accounts, currentUser);
                    break;
                case "4":
  
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