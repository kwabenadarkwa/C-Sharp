//create an interface
//and then create a class that implements the interface
//but then the class should do more than the interface wants it to do
//and then create an instance of that class that is tied to the interface and see what methods that that instance allows you to have access to
//
public interface IPerson
{
    public string Shout();
}

public class Person : IPerson
{
    private string name;
    public int age;

    public Person(string Pname)
    {
        if (string.IsNullOrEmpty(Pname))
        {
            throw new ArgumentException(
                $"'{nameof(Pname)}' cannot be null or empty.",
                nameof(Pname)
            );
        }

        name = Pname;
    }

    public string GetName()
    {
        return name;
    }

    public string Shout()
    {
        return "This is the fucking best person ever";
    }
}

public class StaffMember
{
    private string staffName;
    public string Name
    {
        set
        {
            if (value.Length is > 0 and < 50)
            {
                this.staffName = value;
            }
        }
        get => this.staffName;
    }
}

public static class InterfaceTest
{
    public static void Main()
    {
        Person Kwabena = new Person("Kwabena");
        string name = Kwabena.GetName();
        Kwabena.age = 10;
        Console.WriteLine(name);

        IPerson Kofi = new Person("Kofi");
        //INFO: the statement below would be an error because even though Kofi is a person
        //it holds a reference to an object that has the shout method only
        // string persoNname = Kofi.GetName();
        string s1 = "Rob";
        string s2 = s1;

        int i1 = 1;
        int i2 = i1;

        i2 = 5;
        Console.WriteLine(i1 + " " + i2);
        // s2 = "different";
        Console.WriteLine(s1 + " " + s2);
    }
}
