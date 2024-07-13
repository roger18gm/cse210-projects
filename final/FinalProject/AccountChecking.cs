public class AccountChecking : Account {

    public AccountChecking(int accountNumber, decimal balance) : base(accountNumber, balance) {

    }

    public override string ToString() {
        return $"Checking ~ Available Balance: ${GetBalance()}    Account Number: {GetAccountNumber()}";
    }
}