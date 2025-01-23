using System;

// Base Class (Abstract Class)
public abstract class ATM
{
    public string Brand;
    public int Wheels;

    public void InsertCard()
    {
        Console.WriteLine("Card Inserted");
    }

    public abstract void EnterPin(); // Abstract method, to be implemented by derived classes

    public void WithdrawMoney()
    {
        Console.WriteLine("Money Withdrawn");
    }

    public void CheckBalance()
    {
        Console.WriteLine("Balance Checked");
    }
}

// Derived Class 1 - BankATM
public class BankATM : ATM
{
    public override void EnterPin()
    {
        Console.WriteLine("Pin Entered in BankATM");
    }
}

// Derived Class 2 - MobileATM
public class MobileATM : ATM
{
    public override void EnterPin()
    {
        Console.WriteLine("Pin Entered via Mobile App");
    }
}

// Derived Class 3 - OnlineATM
public class OnlineATM : ATM
{
    public override void EnterPin()
    {
        Console.WriteLine("Pin Entered via Online Portal");
    }
}

class Program
{
    static void Main()
    {
        ATM bankATM = new BankATM();
        ATM mobileATM = new MobileATM();
        ATM onlineATM = new OnlineATM();

        bankATM.InsertCard();
        bankATM.EnterPin();
        bankATM.WithdrawMoney();
        bankATM.CheckBalance();

        mobileATM.InsertCard();
        mobileATM.EnterPin();
        mobileATM.WithdrawMoney();
        mobileATM.CheckBalance();

        onlineATM.InsertCard();
        onlineATM.EnterPin();
        onlineATM.WithdrawMoney();
        onlineATM.CheckBalance();
    }
}



/*

using System;

// Interface - ATM Operations
public interface IATM
{
    void InsertCard();
    void EnterPin();
    void WithdrawMoney();
    void CheckBalance();
}

// Implementing Interface 1 - BankATM
public class BankATM : IATM
{
    public void InsertCard()
    {
        Console.WriteLine("Card Inserted in BankATM");
    }

    public void EnterPin()
    {
        Console.WriteLine("Pin Entered in BankATM");
    }

    public void WithdrawMoney()
    {
        Console.WriteLine("Money Withdrawn from BankATM");
    }

    public void CheckBalance()
    {
        Console.WriteLine("Balance Checked in BankATM");
    }
}

// Implementing Interface 2 - MobileATM
public class MobileATM : IATM
{
    public void InsertCard()
    {
        Console.WriteLine("Card Inserted via MobileATM App");
    }

    public void EnterPin()
    {
        Console.WriteLine("Pin Entered via MobileATM App");
    }

    public void WithdrawMoney()
    {
        Console.WriteLine("Money Withdrawn from MobileATM");
    }

    public void CheckBalance()
    {
        Console.WriteLine("Balance Checked in MobileATM");
    }
}

// Implementing Interface 3 - OnlineATM
public class OnlineATM : IATM
{
    public void InsertCard()
    {
        Console.WriteLine("Card Inserted via OnlineATM Portal");
    }

    public void EnterPin()
    {
        Console.WriteLine("Pin Entered via OnlineATM Portal");
    }

    public void WithdrawMoney()
    {
        Console.WriteLine("Money Withdrawn from OnlineATM");
    }

    public void CheckBalance()
    {
        Console.WriteLine("Balance Checked in OnlineATM");
    }
}

class Program
{
    static void Main()
    {
        // Create objects of different ATM types using the IATM interface
        IATM bankATM = new BankATM();
        IATM mobileATM = new MobileATM();
        IATM onlineATM = new OnlineATM();

        // Calling methods on each ATM object
        bankATM.InsertCard();
        bankATM.EnterPin();
        bankATM.WithdrawMoney();
        bankATM.CheckBalance();

        mobileATM.InsertCard();
        mobileATM.EnterPin();
        mobileATM.WithdrawMoney();
        mobileATM.CheckBalance();

        onlineATM.InsertCard();
        onlineATM.EnterPin();
        onlineATM.WithdrawMoney();
        onlineATM.CheckBalance();
    }
}
*/