public class Utils {
    public static string ValidInput() {
        string? input;

        while (true) {
            input = Console.ReadLine();
            if(string.IsNullOrEmpty(input)) {
                Console.WriteLine("Invalid input!");
                continue;
            }
            break;
        }
        return input;
    }

    // this will be replalced with a tablelookup / something to store it?
    public static string CreatePassword(){
        string pwd, temp;
        while(true) {
            Console.WriteLine("Enter a Password");
            pwd = ValidInput();

            Console.WriteLine("Confirm Password");
            temp = ValidInput();

            if(!string.Equals(pwd, temp)) {
                Console.WriteLine("Password does not match, please try again");
                continue;
            } 
            break;
        }

        return pwd;

    }
}