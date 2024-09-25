public class ArrayDemo
{
    private static string ReadString(string prompt)
    {
        string result;
        do
        {
            Console.Write(prompt);
            result = Console.ReadLine();
        } while (result == "");
        return result;
    }

    private static int ReadInt(string prompt, int low, int high)
    {
        int result;
        do
        {
            string intString = ReadString(prompt);
            result = int.Parse(intString);
        } while ((result < low) || (result > high));
        return result;
    }

    public static void Main()
    {
        const int TEAM_SIZE = 11;
        int[] scores = new int[TEAM_SIZE];
        for (int i = 0; i < TEAM_SIZE; i++)
        {
            scores[i] = ReadInt("Score: ", 0, 1000);
        }
        //it seems to be the case that in c# you can't just print the array like that
        // you have to step inside one one to print things from it
        for (int i = 0; i < TEAM_SIZE; i++)
        {
            Console.WriteLine(scores[i]);
        }
        //basically you can do something like this when you're initializing and also assigning the values straight away 
        string[] monthsa = new string[11];
        string[] months =
        [
            null, // null element for non existent month 0
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December",
        ];
    }
}
