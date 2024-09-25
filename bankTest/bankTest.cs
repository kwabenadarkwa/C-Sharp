public class Account
{
    public string Name;
}

public class StructsAndObjectsDemo
{
    public static void Main()
    {
        Account RobsAccount = new()
        {
            Name = "Rob"
        };
        Console.WriteLine(RobsAccount.Name);
    }
}
