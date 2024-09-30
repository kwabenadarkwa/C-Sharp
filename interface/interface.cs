public interface IAccount
{
    void PayInFunds(decimal amount);
    bool WithdrawFunds(decimal amount);
    decimal GetBalance();
}

public interface IPrintToPaper
{
    void DoPrint();
}

//INFO: a class can have as many interfaces as it wishes to have
public class Account : IAccount, IPrintToPaper
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

    public void DoPrint() { }

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

    public virtual bool WithdrawFunds(decimal amount)
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

//INFO: an example of how we are implementing an interface in a different way even
//though wer're using the same methods
public class BabyAccount : Account, IAccount
{
    public override bool WithdrawFunds(decimal amount)
    {
        if (amount > 10)
        {
            return false;

        }
        //INFO: this allows us to access the private properties of the parent class
        return base.WithdrawFunds(amount);
    }
}

public class Interfaces
{
    public static void Main()
    {
        IAccount Kwabena = new Account("Kwabena", "B4 89/20", 10001001010);
        IAccount Ohemaa = new BabyAccount();
    }
}
