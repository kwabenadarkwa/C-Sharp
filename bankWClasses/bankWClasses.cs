public class Account
{
    private string name;
    private string address = "";
    private decimal balance = 0;

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

public class Bank
{
    public static void Main()
    {
        Account RobsAccount;
        RobsAccount = new Account();
        if (RobsAccount.WithdrawFunds(5))
        {
            Console.WriteLine("Cash Withdrawn");
        }
        else
        {
            Console.WriteLine("Insufficient Funds");
        }
        Account test = new Account(Cname: "Kwabena", Caddress: "NG7 2BS", Cbalance: 10000000000);
        test.PayInFunds(50);
        if (test.GetBalance() != 50)
        {
            Console.WriteLine("Pay In test failed");
        }
        else
        {
            Console.WriteLine("Pay In test succeeded");
        }
    }
}
