using System;

// Abstract Class - ATM Machine
public abstract class ATM
{
    // Abstract method: The ATM machine must have these operations, but the implementation will be in the derived classes
    public abstract void InsertCard();
    public abstract void EnterPin();
    public abstract void WithdrawMoney();
    public abstract void CheckBalance();

    // Concrete method: This functionality is the same for all ATMs
    public void ShowInstructions()
    {
        Console.WriteLine("Welcome to the ATM!");
        Console.WriteLine("1. Insert Card");
        Console.WriteLine("2. Enter Pin");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Check Balance");
    }
}

// Derived Class - Specific ATM
public class BankATM : ATM
{
    public override void InsertCard()
    {
        Console.WriteLine("Card Inserted");
    }

    public override void EnterPin()
    {
        Console.WriteLine("Pin Entered Successfully");
    }

    public override void WithdrawMoney()
    {
        Console.WriteLine("Money Withdrawn");
    }

    public override void CheckBalance()
    {
        Console.WriteLine("Your Balance is $.....");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of derived class BankATM
        ATM myATM = new BankATM();

        // Calling the common method that is implemented in the abstract class
        myATM.ShowInstructions();

        // Performing ATM operations
        myATM.InsertCard();
        myATM.EnterPin();
        myATM.WithdrawMoney();
        myATM.CheckBalance();
    }
}




// Using a interface 

// Interface - ATM Operations
// public interface IATM
// {
//     void InsertCard();    // Method signature for inserting card
//     void EnterPin();      // Method signature for entering pin
//     void WithdrawMoney(); // Method signature for withdrawing money
//     void CheckBalance();  // Method signature for checking balance
// }

// // Implementing the Interface - BankATM
// public class BankATM : IATM
// {
//     public void InsertCard()
//     {
//         Console.WriteLine("Card Inserted");
//     }

//     public void EnterPin()
//     {
//         Console.WriteLine("Pin Entered Successfully");
//     }

//     public void WithdrawMoney()
//     {
//         Console.WriteLine("Money Withdrawn");
//     }

//     public void CheckBalance()
//     {
//         Console.WriteLine("Your Balance is $1000");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Creating an object of derived class BankATM that implements IATM
//         IATM myATM = new BankATM();

//         // Performing ATM operations
//         myATM.InsertCard();
//         myATM.EnterPin();
//         myATM.WithdrawMoney();
//         myATM.CheckBalance();
//     }
// }
 