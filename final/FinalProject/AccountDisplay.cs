public class AccountDisplay {

    // Displays list of accounts and User info
    public void ListInfo(List<Account> accounts, User user) {
        
        Console.Clear();
        int count = 1;

        Console.WriteLine(user);

        foreach (var account in accounts) {
            
            Console.WriteLine($"{count}. {account}");

            count++;
        }

        Console.ReadLine();
    }
}