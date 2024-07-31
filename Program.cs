using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankManager manager = new BankManager();
            
            // menu options
            // login
            // signup

            ConsoleManager.PrintWelcomePage();

            // signup
            manager.SignUp();
            Console.WriteLine("Thank you for signing up");


            // Bank
            // contains People -> name, password, phone number, bank accounts

            // people -> list of people

            // name (first and last) -> strings can loopup first or last to find a list of all of them
            // password -> string used to log into account
            // phone number -> int used as another lookup / verification
            
            // bank accounts -> account1, account name, account num  balance, deposit withdraw, transfer
            // account1 -> bank account (people can have multiple ie savings vs spendings)
            // account name, user can lookup account name
            // account number used in transfering 
            // balance -> how much money is in account
            // deposit withdraw -> methods to add or remove money from account
            // transfer, transfer money either locally (ie one account to another) or to another person using their phonenumber and account id

            // get base implementation working and then make terminal look nice
            // use sqllite to store user data, will make lookups easy too!
        }
    }
}