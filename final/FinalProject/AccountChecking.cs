public class AccountChecking : Account {

    public AccountChecking(int accountNumber, int balance) : base(accountNumber, balance) {

    }

    public override void MinAmount()
    {
        throw new NotImplementedException();
    }
    public override bool CanTransfer() {
        return false;
    }
    // ONLY 1 OR 2 CHECKING ACCOUNTS???????????????
    public override string ToString() {
        return $"Checking ~ Balance: ${GetBalance()}    Account Number: {GetAccountNumber()}";
    }
}