
using CargoManager;

class Program
{ 
    static void Main()
    {
        Ship ship = new Ship(5, 500, 30);
        
        LiquidContainer liquidContainer = new LiquidContainer(150, 8, 4, 40, true);
        GasContainer gasContainer = new GasContainer(200, 10, 5, 50, 10);
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(100, 6, 3, 30, "Fish", 2);
        
        ship.AddContainer(liquidContainer);
        ship.AddContainer(gasContainer);
        ship.AddContainer(refrigeratedContainer);

        liquidContainer.LoadCargo(70);
        gasContainer.LoadCargo(50);
        refrigeratedContainer.LoadCargo(40);
        
        Console.WriteLine(ship);
        Console.WriteLine(liquidContainer);
        Console.WriteLine(gasContainer);
        Console.WriteLine(refrigeratedContainer);
    }
}