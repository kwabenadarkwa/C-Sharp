public class Bank
{
    public enum AccountState
    {
        New,
        Active,
        UnderAudit,
        Frozen,
        Closed,
    }

    public struct Account
    {
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdraft;
    }

    public static void PrintAccount(Account a)
    {
        Console.WriteLine("Name:" + a.Name);
        Console.WriteLine("Address:" + a.Address);
        Console.WriteLine("Balance:" + a.Balance);
    }

    public static void Main()
    {
        const int MAX_CUST = 100;
        Account[] Bank = new Account[MAX_CUST];
        Bank[0].Name = "KwabenasAccount";
        Bank[0].State = AccountState.Active;
        Bank[0].Balance = 10000000;
        Bank[0].Address = "NG7 2BS";
        PrintAccount(Bank[0]);
    }
}
