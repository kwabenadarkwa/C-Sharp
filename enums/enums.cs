public class Enums
{
    private enum SeaState : int
    {
        EmptySea = 1,
        Attacked,
        Battleship,
        Cruiser,
        Submarine,
        RowingBoat,
    };

    private enum Numbers : int
    {
        thing,
    }

    public static void Main()
    {
        SeaState openSea;
        openSea = SeaState.EmptySea;
        Console.WriteLine(openSea.GetType());
        Console.WriteLine(openSea);
    }
}
