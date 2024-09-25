public class Exceptions
{
    public static void Main()
    {
        int age;
        string ageString = Console.ReadLine();
        try
        {
            age = int.Parse(ageString);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            // throw;
        }
    }
}
