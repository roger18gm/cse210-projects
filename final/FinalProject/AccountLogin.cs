using System.Text.Json;
using System.IO;

public class AccountLogin {

    private string currentDirectory;

    public AccountLogin() {
        currentDirectory = Directory.GetCurrentDirectory();
    }

    public (User, List<Account>) LogInPrompt() {
        // Returns instance of User and list of accounts
        Console.Clear();
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        // Locates filename with username
        string filePath = Path.Combine(currentDirectory, $"{username}.json");

        if (File.Exists(filePath)) {
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true
            };
            // Deserializes the JSON file if it exists
            var data = JsonSerializer.Deserialize<JsonData>(jsonString, options);
            // Validates username and password and adds the data to the User and Account list
            if (data.User[2] == username && data.User[3] == password) {
                User user = new User(data.User[0], data.User[1], data.User[2], data.User[3]);
                List<Account> accounts = new List<Account>();

                // Adds each existing Checking account
                foreach (var accountData in data.Accounts.AccountChecking) {
                    accounts.Add(new AccountChecking(
                        int.Parse(accountData[0]),
                        int.Parse(accountData[1])
                    ));
                }

                // Adds each existing Checking account
                foreach (var accountData in data.Accounts.AccountSaving) {
                    accounts.Add(new AccountSavings(
                        int.Parse(accountData[0]),
                        int.Parse(accountData[1])
                    ));
                }
                Console.WriteLine("Logged in successfully! ");
                Thread.Sleep(2000);
                return (user, accounts);
            } 
        } else {
            Console.WriteLine("User not found. Become a member today!");
        }

        return (null, null);
    }
}

public class JsonData { // Class with list of user info and accounts
    public List<string> User { get; set; }
    public AccountData Accounts { get; set; }
}

public class AccountData { // List of lists with account info
    public List<List<string>> AccountChecking { get; set; }
    public List<List<string>> AccountSaving { get; set; }
}