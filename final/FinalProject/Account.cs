using System.Text.Json.Serialization;
public abstract class Account {
    [JsonInclude]
    private int accountNumber;
    [JsonInclude]
    private int balance;

    public Account(int accountNumber, int balance) {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
    public abstract void MinAmount(); 

    public abstract bool CanTransfer();

    public abstract override string ToString();
    public int GetAccountNumber() {
        return accountNumber;
    }

    public int GetBalance() {
        return balance;
    }


}