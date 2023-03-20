using static System.Formats.Asn1.AsnWriter;
using System;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a new public class named BankAccount
            //In your BankAccount class, create the following:
            //A private field of type double named balance with a value of 0
            //Define a method named Deposit that will accept a double and store that value in the balance field
            //Define a method named GetBalance that will return the amount stored in the balance field
            //In the main method of your application, create a new instance of the BankAccount class.
            //Allow the user of the application to Deposit money and retrieve their balance through the console.

            var account = new BankAccount();
            Console.WriteLine("How much would you like to deposit into your account today?");

            var depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.WriteLine($"Thank you for your deposit of {depositAmount}. \n" +
                $"Would you like to see your balance?");

            //For the life of me I can't remember how to use ToLower, will look it up later.s

            var userInput = Console.ReadLine();

            if (userInput == "Yes")
            {
                Console.WriteLine($"Your balance is currently {account.GetBalance()}.");
            }
            else if (userInput == "yes")
            {
                Console.WriteLine($"Your balance is currently {account.GetBalance()}.");
            }
            else
            {
                Console.WriteLine("Have a great day!");
            }


        }
    }
}
