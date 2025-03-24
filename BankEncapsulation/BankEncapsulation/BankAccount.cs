using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()//this is what's known as a constructor -- also known as a special member method. Constructors, like objects, can be used to instantiate the classes from which they're from, and this is a good example of how they don't even need any script written within their scope to enact this notion.
        {//this is also another way in which a class is instantiated.... so now that this class has been instantiated, we can do stuff with it, without facing runtime errors.

        }
        private double balance = 0.00;//defining what the field 'balance' is. Fields are like variables in our class. Properties allow us to have more flexibility when working with fields (get; set; as an example) -- allows us to manipulate fields.

        public double Balance//creating and defining a property called, Balance. I noticed that it doesn't seem to matter whether or not the name of this property retains any similarity to any respective field it may or may not be manipulating/eworking with.... so long as whatever you title it here matches what's written into the main method in the other program.
        {
            get
            {
                return balance;//this is what the property will yield when called in a function, say Console.WriteLine (using dot notation).
            }
            set
            {
                balance = value;
            }
        }
        public void BalanceReplacement(double amount)//(double userDeposit)//this is an instance of what's known as a special member method.... essentially a method that is written within the scope of a class. It defines actions that a class can perform, just like a regular method would (without being written within a class, and therefore not a special member method).
        {//this method provides the only access a user has to the private field (balance) -- this would be an instance of encapsulation. This allows the user to place a value within this field, but without manipulating it.
            balance = amount;//here, we've created a method that will accept a double and will then store that value in the balance field. The double has to be called something, and this is easy enough to do through variable declaration.
            //userDeposit.TryParseConsole.ReadLine();
        }//this method would be categorized as a balance value replacement because it is only going to change whatever the current balance value is to whatever input it takes in, without necessarily adding to it, or subtracting from it.... it is only having user input being set equal to it.

        public void Deposit(double amount)
        {
            balance = balance + amount;//I think this works the same way as the line of code written in below. I'll test it and see. Updated; looks like this does work!
            //balance += amount;
        }

        public void Withdraw(double amount)
        {
            //balance = balance - amount;
            balance -= amount;
        }

        public double GetBalance()//this method returns the amount stored within the balance field.
        {
            return balance;
        }

        public string GetBalanceString()//this method returns the amount stored within the balance field, but takes in strings instead.
        {
            return $"{balance}";
        }
    }


}
