namespace CargoManager;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; set; }

    public LiquidContainer(double maxLoad, double height, double depth, double tareWeight, bool isHazardous) 
        : base("Liquid", 0, maxLoad, height, depth, tareWeight)
    {
        IsHazardous = isHazardous;
    }
    
    public override void LoadCargo(double mass)
    {
        double Limit = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if(mass + CurrentLoad > Limit)
            HazardNotifier("Hazardous liquid overload attempt!");
        base.LoadCargo(mass);
    }

    public void HazardNotifier(string message)
    {
        Console.WriteLine($"HAZARD - {SerialNumber}: {message}");
    }
}