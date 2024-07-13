public class AccountSavings : Account {

    public AccountSavings(int accountNumber, decimal balance) : base(accountNumber, balance) {

    }
    
    public override string ToString() {
        return $"Savings ~ Available Balance: ${GetBalance()}    Account Number: {GetAccountNumber()}";
    }
    // a one word title for savings account?
}