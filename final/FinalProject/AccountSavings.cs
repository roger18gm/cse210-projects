public class AccountSavings : Account {

    public AccountSavings(int accountNumber, int balance) : base(accountNumber, balance) {

    }

    public override void MinAmount()
    {
        throw new NotImplementedException();
    }
    public override bool CanTransfer() {
        return false;
    }
    // 3 SAVINGS ACCOUNTS MAX???????
    public override string ToString() {
        return $"Savings ~ Available Balance: ${GetBalance()}    Account Number: {GetAccountNumber()}";
    }
    // a one word title for savings account?
}