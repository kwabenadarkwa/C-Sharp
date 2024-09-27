public interface IAccount
{
    void PayInFunds(decimal amount);
    bool WithdrawFunds(decimal amount);
    decimal GetBalance();
}

public class Account : IAccount
{
    private string name;
    private string address;
    private decimal balance;

    //we have a static interest rate charge becuase we want it to be a member of the class and not a member of an instance of the class
    private static decimal InterestRateCharged;
    private static readonly int minAge = 18;
    private static readonly decimal minIncome = 10000;

    //constructor allows us to define what happens when an instance of a class is created
    //it is mostly the same name as the class,
    //it is basically a method that allows us to set up the object that is being created
    public Account(string Cname, string Caddress, decimal Cbalance)
    {
        name = Cname;
        address = Caddress;
        balance = Cbalance;
    }

    // INFO: this is another way of doing this
    // public Account(string Cname, string Caddress)
    // {
    //     name = Cname;
    //     address = Caddress;
    //     balance = 0;
    // }

    public Account(string Cname, string Caddress)
        : this(Cname, Caddress, 0) { }

    public Account()
        : this("", "", 0) { }

    public static void SetInterestRateCharged(decimal amount)
    {
        InterestRateCharged = amount;
    }

    public static decimal GetInterestRateCharged()
    {
        return InterestRateCharged;
    }

    public bool WithdrawFunds(decimal amount)
    {
        if (balance < amount)
        {
            return false;
        }
        balance -= amount;
        return true;
    }

    public void PayInFunds(decimal amount)
    {
        balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public static bool AccountAllowed(decimal income, int age)
    {
        if ((income >= minIncome) && (age >= minAge))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Interfaces
{
    public static void Main()
    {
        Account Kwabena;
        Kwabena = new Account("Kwabena", "B4 89/20", 10001001010);
    }
}
