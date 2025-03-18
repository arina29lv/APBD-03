namespace CargoManager;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }


    public GasContainer(double maxLoad, double height, double depth, double tareWeight, double pressure) 
        : base("Gas", 0, maxLoad, height, depth, tareWeight)
    {
        Pressure = pressure;
    }

    public override void UnloadCargo()
    {
        CurrentLoad *= 0.005;
    }
    
    public void HazardNotifier(string message)
    {
        Console.WriteLine($"HAZARD - {SerialNumber}: {message}");
    }
}