public class ReferencingExample
{
    private static void Plusone(ref int i)
    {
        i++;
        Console.WriteLine("i is : " + i);
    }

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

    private static void ReadPerson(out string name, out int age)
    {
        name = ReadString("Enter your name : ");
        age = ReadInt("Enter your age : ", 0, 100);
    }

    private static void Main()
    {
        int test;
        test = 20;
        Plusone(ref test);
        Console.WriteLine("test is : " + test);
        string name;
        int age;
        ReadPerson(out name, out age);
        Console.WriteLine("this is the name {0:0.0} \n this is the age {1}", name, age);
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("shut up length");
            }
        }
        //this works here because it is not a nested for statement and it out of scope of the previous i 
        for (int i = 0; i < 10; i++)
        {
          Console.WriteLine("This one works because it is out of scope");
            
        }
    }
}
