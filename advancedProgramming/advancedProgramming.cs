namespace advancedProgramming
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
        string GetName();
        void SetName(string NewName);
    }

    public class CustomerAccount : IAccount
    {
        public CustomerAccount(string NewName, decimal InitialBalance)
        {
            name = NewName;
            balance = InitialBalance;
        }

        private string name;
        private decimal balance = 0;

        public virtual bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance -= amount;
            return true;
        }

        public void SetName(string NewName)
        {
            name = NewName;
        }

        public void PayInFunds(decimal amount)
        {
            balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public string GetName()
        {
            return name;
        }

        public bool Save(string filename)
        {
            TextWriter textOut = null;
            try
            {
                textOut = new StreamWriter(filename);
                Save(textOut);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
            return true;
        }

        public void Save(TextWriter textOut)
        {
            textOut.WriteLine(name);
            textOut.WriteLine(balance);
        }

        public static CustomerAccount Load(System.IO.TextReader textIn)
        {
            CustomerAccount result = null;
            try
            {
                string name = textIn.ReadLine();
                string balanceText = textIn.ReadLine();
                decimal balance = decimal.Parse(balanceText);
                result = new CustomerAccount(name, balance);
            }
            catch { }
            return null;
            return result;
        }
    }

    public class AccountEditTextUI
    {
        private IAccount account;

        public AccountEditTextUI(CustomerAccount inAccount)
        {
            account = inAccount;
        }

        public void EditName()
        {
            string newName;
            Console.WriteLine("Name Edit");
            while (true)
            {
                Console.Write("Enter new name: ");
                newName = Console.ReadLine();
            }
        }
    }

    class SaveDemo
    {
        public static void Main()
        {
            // CustomerAccount test = new CustomerAccount("Kwabena", 1000000);
            // Console.WriteLine(test.GetType());
            // // test.Save(textOut)
            // test.Save("Test.txt");
            // // TextReader textIn = new StreamReader("Test.txt");
            // CustomerAccount loaded = CustomerAccount.Load(textIn);
            // Console.WriteLine(loaded.GetName());
            BusyLoop();
        }

        private static void BusyLoop()
        {
            long count;
            for (count = 0; count < 10000000000000L; count++) { }
        }
    }
}
