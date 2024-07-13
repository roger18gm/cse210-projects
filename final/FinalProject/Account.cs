using System.Text.Json.Serialization;
public abstract class Account {
    [JsonInclude]
    private int accountNumber;
    [JsonInclude]
    private decimal balance;

    public Account(int accountNumber, decimal balance) {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public abstract override string ToString();
    public int GetAccountNumber() {
        return accountNumber;
    }

    public decimal GetBalance() {
        return balance;
    }

    public decimal SetBalance(decimal newBalance) {
        return balance = newBalance;
    }


}