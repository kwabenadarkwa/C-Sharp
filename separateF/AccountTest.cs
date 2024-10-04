using CustomerBanking;

public class AccountTest
{
    public static void Main()
    {
        Account test = new Account();
        test.PayInFunds(50);
        Console.WriteLine("Balance:" + test.GetBalance());
    }
}
