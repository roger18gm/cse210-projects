using System.Text.Json;
using System.IO;
public class AccountSave {
    private Menu menu;

    public AccountSave(Menu menu) {
        this.menu = menu;
    }
    public void SerializetoJson(List<Account>accounts, User user) {
        
        string fileName = $"{user.GetUsername()}.json";

        var accountChecking = new List<List<string>>();
        var accountSaving = new List<List<string>>();

        foreach (var account in accounts) {
            if (account is AccountChecking) {
                accountChecking.Add(new List<string> {
                    account.GetAccountNumber().ToString(),
                    account.GetBalance().ToString()
                });
            } else if (account is AccountSavings) {
                accountSaving.Add(new List<string> {
                    account.GetAccountNumber().ToString(),
                    account.GetBalance().ToString()
                });
            }
        }

        var data = new {
            User = new List<string> { user.GetFirstName(), user.GetLastName(), user.GetUsername(), user.GetPassword() },
            Accounts = new {
                AccountChecking = accountChecking,
                AccountSaving = accountSaving
            }
        };

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(data, options);
        File.WriteAllText(fileName, jsonString);
    }
}

        // var data = new {
        //     User = user,
        //     Accounts = accounts
        // };