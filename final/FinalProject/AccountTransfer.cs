using System.Text.Json;
using System.IO;
using System.Xml;
public class AccountTransfer {

    private string currentDirectory;
    public AccountTransfer() {
        currentDirectory = Directory.GetCurrentDirectory();
    }     
    public void TransferFunds(List<Account>accounts) {
        // Lists users bank accounts
        int count = 1;
        Console.WriteLine("Which account would you like to transfer from? ");
        foreach (var account in accounts) {
            Console.WriteLine($"{count}. {account}");
            count++;
        }
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();


        var chosenAccount = accounts[choice - 1];
        var accountBalance = chosenAccount.GetBalance();

        // Retrieves recipients info
        Console.WriteLine();
        Console.WriteLine("Enter recipients account number: ");
        string recAccNum = Console.ReadLine();
        Console.WriteLine("Enter recipients first name: ");
        string recfName = Console.ReadLine();
        Console.WriteLine("Enter recipients last name: ");
        string reclName = Console.ReadLine();
        Console.WriteLine("Enter transfer amount (ex: 100.00): $ ");
        decimal transferAmount = decimal.Parse(Console.ReadLine());

        // Checks that there are available amounts
        while (transferAmount > chosenAccount.GetBalance()) {
            Console.WriteLine("Transfer amount can't be greater than account balance. Please enter a smaller amount.");
            Console.WriteLine("Enter transfer amount (ex: 100.00): $ ");
            transferAmount = decimal.Parse(Console.ReadLine());
        }

        string[] files = Directory.GetFiles(currentDirectory, "*.json");
    
        foreach (string file in files) {
            string jsonString = File.ReadAllText(file);

            bool isRecipientFound = false;

            var data = JsonSerializer.Deserialize<JsonData>(jsonString);

            // Validates recipients first and last name
            if (data.User[0] == recfName && data.User[1] == reclName) {

                foreach (var account in data.Accounts.AccountChecking) {
                    // Updates balance of recipient if it was sent to Checking
                    if (account[0] == recAccNum) {
                        decimal recBalance = decimal.Parse(account[1]);
                        account[1] = (recBalance + transferAmount).ToString();
                        isRecipientFound = true;
                        break;
                    } 
                }

                if (!isRecipientFound) {

                    foreach (var account in data.Accounts.AccountSaving) {
                    // Updates balance of recipient if it was sent to Savings
                        if (account[0] == recAccNum) {
                            decimal recBalance = decimal.Parse(account[1]);
                            account[1] = (recBalance + transferAmount).ToString();
                            isRecipientFound = true;
                            break;
                        }
                    }
                }

                if (isRecipientFound) {
                    // Serializes the JSON file
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    jsonString = JsonSerializer.Serialize(data, options);
                    File.WriteAllText(file, jsonString);
                    Console.WriteLine("Transfer Successful!");
                    Thread.Sleep(1000);
                    var newBalance = accountBalance - transferAmount;
                    chosenAccount.SetBalance(newBalance);
                    return;
                }
            }
        }
        Console.WriteLine("Recipient not found or incorrect credentials.");
    }
}