namespace TheBuilding;

class Program
{
    static void Main(string[] args)
    {
    

        Building building1 = new Building(5, 15);

        
        Console.WriteLine(building1.GetFloorMaxSize());

        
        Console.WriteLine(building1.GetFloorCount());

        
        Console.WriteLine(building1.GetSize());
    }
}
