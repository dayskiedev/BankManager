public class Person {   

    public Person(string fn, string ln, string pwd, string num) {
        FirstName = fn;
        LastName = ln;
        password = pwd;
        phoneNum = num;
    }
    public string FirstName = "NULL";
    public string LastName = "NULL";
    public string password = "NULL";
    public string phoneNum = "NULL";
    private List<Account> _accounts = new List<Account>();

    public void CreateAccount() {

    }
    
    public Account GetAccount(string accountName) {
        foreach (Account account in _accounts) {
            if(account.accountName == accountName) {
                return account;
            }
        }
        return null;
    }
    public void PrintInfo() {
        Console.WriteLine(LastName + ", " + FirstName + " (" + phoneNum + ")");
    }

}