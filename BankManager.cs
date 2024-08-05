using System.ComponentModel;

public class BankManager {
    // reformat / remove this when switching to sql lite?
    List<Person> _people = new List<Person>();

    public void SignUp() {
        string fn, ln, em, pwd, num;

        //TODO: add input checking for all this bruh
        Console.WriteLine("Enter your First Name");
        fn = Utils.ValidConsoleInput();    

        Console.WriteLine("Enter your Last Name");
        ln = Utils.ValidConsoleInput();

        Console.WriteLine("Please enter your email");
        em = Utils.ValidConsoleInput();

        Console.WriteLine("Enter your phone numer");
        num = Utils.ValidConsoleInput();

        pwd = Utils.CreatePassword();
        Person p = new Person(fn, ln, em, pwd, num);
        AddPerson(p);
    }

    //login
    // enter first name last name
    // enter password

    // change to bool?
    // if bool state can then switch from login to bank accounts or back to menu if invalid input?

    public void Login() {
        string email, pwd;
        Person? p;

        while(true) {
            Console.WriteLine("Please enter your email (or type q to go back to the main menu)");
            email = Utils.ValidConsoleInput();

            p = GetPersonByEmail(email);
            if(p == null) {
                Console.WriteLine("Unable to find account with this email");
                continue;
            }
            break;
        }


        while(true) {

            Console.WriteLine("PLease enter your password (or type q to go back to the main menu)");
            pwd = Utils.ValidConsoleInput();

            if(pwd != p.password) {
                Console.WriteLine("Invalid Password!");
                continue;
            }
            break;
        }

        Console.WriteLine("Login successful!");
    }

    public void AddPerson(Person p) {
        _people.Add(p);
    }

    public Person? GetPersonByEmail(string input) {
        // list multiple people
        // need to refactor to consider people with the same first name and or last name
        foreach(Person p in _people) {
            if(input == p.email) {
                return p;
            }
        }
        return null;
    }

    public void ListPeople() {
        Console.WriteLine("Currently there are " + _people.Count + " people using this bank");
        foreach (Person p in _people) {
            p.PrintInfo();
        }
    }
}