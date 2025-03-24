namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)//account refers to the name of the instance. Below, we're using a new BankAccount, a new version of our blueprint (class) to create a new object. This will give us access to thing which are made public inside of that class.
        {//this is an example of how we're creating a new instance of the BankAccount class -- var Account = new BankAccount()// the BankAccount() represents a constructor (so, this is one way to write constructors outside of the class which they're based off of).
            var Account = new BankAccount();//this is our BankAccount class being instantiated via being called into the main method in the form of an object (even though we still utilize the var declarator here).
            //Account.Balance = 400;//if we were to have explicitly typed out our instance of the BankAccount class, it would be type BankAccount, but the var declarator already infers that.
            Account.Balance = 0;
            //BankAccount Account = new BankAccount();//this is how the inferred typed instance above would be written if it were explicitly typed. All we're doing here is creating custom types (variable types).
            //Console.WriteLine(Account.Balance);//this syntax works too for the console.WriteLine function, but it only prints its stored integer value to the console without ever suggesting what it is.
            Console.WriteLine("Presenting a bank account balance that happens to be in your name.");
            Console.WriteLine("");
            Console.WriteLine($"Your current account balance is, ${Account.Balance}");//this is where the constructor's get functionality is called and printed to the console. This line of code also more clearly defines what the value of Account.Balance is.
            Console.WriteLine("");
            Console.WriteLine("How much would you like to deposit?");
            Console.WriteLine("");
            var amountToDeposit = double.Parse(Console.ReadLine());//double.TryParse(Console.ReadLine());for some reason, .TryParse didn't work.... some error regarding method overloading?
            Console.WriteLine("");//Remember, any input that's taken in by a Console.ReadLine is going to come in the form of a string.
            Account.Deposit(amountToDeposit);//we defined what the program should do when taking input in the form of a string from a user, by way of storing it within the variable we created above called, amountToDesposit. More flexible and effective way of taking user input rather than just utilizing the Console.ReadLine method by itself.
            Console.WriteLine("");//what's happening here is very simple, but its mechanics might be confusing. Account.Deposit is the account variable we created using the Deposit method we also defined within its custom BankAccount class which again grants us access to the otherwise private balance field we also defined within the same class, and whether it's because of syntax or otherwise, we set the value of our private balance field equal to a new custom variable called 'amount' within the Deposit method, and the amount variable is going to work with the amountToDesposit variable to not only take in a user's input when prompted for one, but also ensure that it's in the desired format (double type).
            Console.WriteLine($"Confirmed; your bank account balance now has a total of ${Account.GetBalance()}.");//if this part of the string interpolation was written in without the parentheses at very end of the extension method, like this {Account.GetBalance}, then the script won't print the user's input to the console properly, and ironically, VS community doesn't throw an error for this issue either.... so chances are that syntactic errors just like this one while they are syntactic in nature aren't necessarily denoted as such by VS Community, and it'll be up to us as software developers to trouble shoot these kinds of errors for ourselves.
            Console.WriteLine("");
        }//Account.Deposit(amountToDeposit);//Here, Account represents our object, .Deposit is the method extension it's using, and (amountToDeposit) is the variable taking in and parsing the user's input.
    }//the purpose of writing all of this in such a specific manner is to control a user's access to information; they must go through all of the controlled channels -- this is encapsulation. Access modifiers are the key to achieving this.
}
