public class BankManager {
    // reformat / remove this when switching to sql lite?
    List<Person> _people = new List<Person>();

    public void SignUp() {
        string fn, ln, pwd, num;

        //TODO: add input checking for all this bruh
        Console.WriteLine("Enter your First Name");
        fn = Console.ReadLine();

        Console.WriteLine("Enter your Last Name");
        ln = Console.ReadLine();

        Console.WriteLine("Enter your phone numer");
        num = Console.ReadLine();

        while(true) {
            Console.WriteLine("Enter a password");
            pwd = Console.ReadLine();

            Console.WriteLine("Confirm this password");
            string temp = Console.ReadLine();

            if(!string.Equals(pwd, temp)) {
                Console.WriteLine("Password does not match, please try again");
                continue;
            } 
            break;
        }
        
        Console.WriteLine("Thank you for signing up, you will now be redirected to the login page");
    }

    public void AddPerson(Person p) {
        _people.Add(p);
    }

    public Person? GetPerson(string input) {
        // list multiple people
        foreach(Person p in _people) {
            if(input == p.FirstName || input == p.LastName || input == p.phoneNum) {
                return p;
            }
        }

        Console.WriteLine("unable to find user");
        return null;
    }

    public void ListPeople() {
        Console.WriteLine("Currently there are " + _people.Count + " people using this bank");
        foreach (Person p in _people) {
            p.PrintInfo();
        }
    }
}