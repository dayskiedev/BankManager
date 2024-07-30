public class Account {
    public string accountName = "";
    public int accountNum;
    public float balance = 0.0f;

    public void Deposit(float num) {
        balance += num;
    }

    public void Withdraw(float num) {
        if(balance - num < 0) {
             Console.WriteLine("You have insufficent funds to withdraw.");
             return;
        }

        balance -= num;
    }

}