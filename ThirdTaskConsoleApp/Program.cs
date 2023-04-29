using ThirdTaskClassLibrary;

public class ZooExcursion
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Zoo");
        try
        {
            Zoo zoo = new Zoo(10);
            zoo.StartZooExcurtion();
        }
        catch
        {
            Console.WriteLine("Sorry, something went wrong and excurtion is stopped.");
        }
        finally
        {
            Console.WriteLine("Thank you for viziting our zoo!");
        }
    }
}