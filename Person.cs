public class Person {   

    Person(string fn, string ln, string pwd, string num) {
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

    public void OpenAccount() {
    }
    public void PrintInfo() {
        Console.WriteLine(LastName + ", " + FirstName + " (" + phoneNum + ")");
    }

}